using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace CruiseSafeCompanion
{
    public partial class frmMain : Form
    {
        private CSC_File _currentFile;

        internal CSC_File CurrentFile { get => _currentFile;
            set
            {
                _currentFile = value;
                readValues();
            }
        }

        private void readValues()
        {
            cbEnableLimiter.Checked = CurrentFile.EnableLimiter;
            ncLimiterFront.Value = (decimal)CurrentFile.LimiterFront;
            ncLimiterRear.Value = (decimal)CurrentFile.LimiterRear;

            cbEnableHighPressureAlarm.Checked = CurrentFile.EnableHighBeep;
            ncHighAlarmFront.Value = (decimal)CurrentFile.HighBeepFront;
            ncHighAlarmRear.Value = (decimal)CurrentFile.HighBeepRear;

            cbEnableLowPressureAlarm.Checked = CurrentFile.EnableLowBeep;
            ncLowAlarmFront.Value = (decimal)CurrentFile.LowBeepFront;
            ncLowAlarmRear.Value = (decimal)CurrentFile.LowBeepRear;

            cbRiseOnStart.Checked = CurrentFile.RiseOnStart;
        }

        private void writeValues()
        {
            CurrentFile.EnableLimiter = cbEnableLimiter.Checked;
            CurrentFile.LimiterFront = (double)ncLimiterFront.Value;
            CurrentFile.LimiterRear = (double)ncLimiterRear.Value;

            CurrentFile.EnableHighBeep = cbEnableHighPressureAlarm.Checked;
            CurrentFile.HighBeepFront = (double)ncHighAlarmFront.Value;
            CurrentFile.HighBeepRear = (double)ncHighAlarmRear.Value;

            CurrentFile.EnableLowBeep = cbEnableLowPressureAlarm.Checked;
            CurrentFile.LowBeepFront = (double)ncLowAlarmFront.Value;
            CurrentFile.LowBeepRear = (double)ncLowAlarmRear.Value;

            CurrentFile.RiseOnStart = cbRiseOnStart.Checked;
        }

        public frmMain()
        {
            InitializeComponent();

            if(Properties.Settings.Default.ChangeLogToShow != null && Properties.Settings.Default.ChangeLogToShow != "")
            {
                new frmChangelog(Properties.Settings.Default.ChangeLogToShow).ShowDialog();
                Properties.Settings.Default.ChangeLogToShow = "";
                Properties.Settings.Default.Save();
            }

            lbVersion.Text = "Version: " + Program.DB_VERSION_NO;
            if (ApplicationUpdater.CheckForNewerVersion())
            {
                lbNewVersion.Text ="(Update available!)";
                lbNewVersion.Enabled = true;
                lbNewVersion.DoubleClickEnabled = true;
                lbNewVersion.ToolTipText = "Double Click to update";
                lbNewVersion.DoubleClick += LbNewVersion_DoubleClick;
                lbNewVersion.BackColor = Color.Green;
            }
            else
            {
                lbNewVersion.Text = "(Up to date)";
                lbNewVersion.Enabled = false;
            }

            lbVersionNo.Text = FirmwareUpdater.CheckForCurrentFirmwareVersion();
            if (lbVersionNo.Text != "")
                lbVersionNo.Text = "V" + lbVersionNo.Text;

            CurrentFile = new CSC_File();
            lbFileName.Text = CurrentFile.FileName;
            getComPorts();
        }

        private void LbNewVersion_DoubleClick(object sender, EventArgs e)
        {
            lbNewVersion.Enabled = false;
            ApplicationUpdater Updater = new ApplicationUpdater();
            Updater.UpdateComplete += Updater_UpdateComplete1;
            Updater.UpdateSoftware();
        }

        private void Updater_UpdateComplete1(ApplicationUpdater.UpdateCompleteEventArgs e)
        {
            if(e.Success)
            {
                Properties.Settings.Default.ChangeLogToShow = e.Changelog;
                Properties.Settings.Default.Save();
                Application.Exit();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentFile = new CSC_File();
            lbFileName.Text = CurrentFile.FileName;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "CSC-Files (*.CSC)|*.CSC";
            OFD.RestoreDirectory = true;
            OFD.Multiselect = false;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                CurrentFile = new CSC_File(OFD.FileName);
                lbFileName.Text = CurrentFile.FileName;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writeValues();
            CurrentFile.FileName = "";
            CurrentFile.Save();

            lbFileName.Text = CurrentFile.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writeValues();
            CurrentFile.Save();

            lbFileName.Text = CurrentFile.FileName;
        }

        void getComPorts()
        {
            cbComPorts.Items.Clear();

            string[] Ports = System.IO.Ports.SerialPort.GetPortNames();
            Ports.ToList().ForEach(P =>
                cbComPorts.Items.Add(P));
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            getComPorts();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void comboboxGotFocus(object sender, EventArgs e)
        {
            NumericUpDown nc = sender as NumericUpDown;
            nc?.Select(0, nc.Text.Length);
        }

        private void btUpdateDevice_Click(object sender, EventArgs e)
        {
            if (cbComPorts.Text != "")
            {
                btCheckFirmware.Enabled = false;
                btUpload.Enabled = false;

                btUpdateDevice.Text = "updating...";
                btUpdateDevice.Enabled = false;

                FirmwareUpdater Updater = new FirmwareUpdater();
                Updater.UpdateComplete += Updater_UpdateComplete;
                Updater.UpdateFirmware(cbComPorts.Text);
            }
            else
                MessageBox.Show("Please select a ComPort first");
        }

        private void Updater_UpdateComplete(FirmwareUpdater.UpdateCompleteEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                btUpdateDevice.Text = "Update";
                btCheckFirmware.Enabled = true;
                btUpdateDevice.Enabled = true;
                btUpload.Enabled = true;
            });

            if (e.Success)
            {
                new frmChangelog(e.Changelog).ShowDialog();
            }
            else
            {

            }
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            if (cbComPorts.Text != "")
            {
                btCheckFirmware.Enabled = false;
                btUpdateDevice.Enabled = false;
                btUpload.Enabled = false;

                writeValues();
                SettingsUploader uploader = new SettingsUploader(cbComPorts.Text, _currentFile);
                uploader.Upload();

                btCheckFirmware.Enabled = true;
                btUpdateDevice.Enabled = true;
                btUpload.Enabled = true;
            }
            else
                MessageBox.Show("Please select a ComPort first");
        }

        private void btCheckFirmware_Click(object sender, EventArgs e)
        {
            if (cbComPorts.Text != "")
            {
                btCheckFirmware.Enabled = false;
                btUpdateDevice.Enabled = false;
                btUpload.Enabled = false;

                string version = FirmwareUpdater.GetDeviceVersion(cbComPorts.Text);
                if (version != "")
                    lbDeviceVersion.Text = "V" + version.Replace("<VERSION>", "").Replace("</VERSION>", "");

                btCheckFirmware.Enabled = true;
                btUpdateDevice.Enabled = true;
                btUpload.Enabled = true;
            }
            else
                MessageBox.Show("Please select a ComPort first");
        }
    }
}
