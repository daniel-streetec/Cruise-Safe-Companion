using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruiseSafeCompanion
{
    public partial class frmMain : Form
    {
        private CSC_File _currentFile;
        private BindingSource _bsCurrentFile;

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

            _currentFile = new CSC_File();
            lbFileName.Text = _currentFile.FileName;
            addDatabindings();

            _bsCurrentFile.DataSource = _currentFile;
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

        void addDatabindings()
        {
            _bsCurrentFile = new BindingSource { DataSource = typeof(CSC_File) };

            cbEnableLimiter.DataBindings.Add("Checked", _bsCurrentFile, "EnableLimiter");
            ncLimiterFront.DataBindings.Add("Value", _bsCurrentFile, "LimiterFront");
            ncLimiterRear.DataBindings.Add("Value", _bsCurrentFile, "LimiterRear");

            cbEnableHighPressureAlarm.DataBindings.Add("Checked", _bsCurrentFile, "EnableHighBeep");
            ncHighAlarmFront.DataBindings.Add("Value", _bsCurrentFile, "HighBeepFront");
            ncHighAlarmRear.DataBindings.Add("Value", _bsCurrentFile, "HighBeepRear");

            cbEnableLowPressureAlarm.DataBindings.Add("Checked", _bsCurrentFile, "EnableLowBeep");
            ncLowAlarmFront.DataBindings.Add("Value", _bsCurrentFile, "LowBeepFront");
            ncLowAlarmRear.DataBindings.Add("Value", _bsCurrentFile, "LowBeepRear");

            cbRiseOnStart.DataBindings.Add("Checked", _bsCurrentFile, "RiseOnStart");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentFile = new CSC_File();
            _bsCurrentFile.DataSource = _currentFile;
            lbFileName.Text = _currentFile.FileName;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "CSC-Files (*.CSC)|*.CSC";
            OFD.RestoreDirectory = true;
            OFD.Multiselect = false;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                _currentFile = new CSC_File(OFD.FileName);
                _bsCurrentFile.DataSource = _currentFile;
                lbFileName.Text = _currentFile.FileName;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentFile.FileName = "";
            if (this.ActiveControl.DataBindings.Count > 0)
                this.ActiveControl.DataBindings[0].WriteValue();
            _currentFile.Save();

            lbFileName.Text = _currentFile.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl.DataBindings.Count > 0)
                this.ActiveControl.DataBindings[0].WriteValue();
            _currentFile.Save();

            lbFileName.Text = _currentFile.FileName;
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
                btUpdateDevice.Enabled = true;
            });

            if (e.Success)
            {
                new frmChangelog(e.Changelog).ShowDialog();
            }
            else
            {

            }
        }
    }
}
