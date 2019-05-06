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
            cbBtInvert.Checked = CurrentFile.BtInvert;
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
            CurrentFile.BtInvert = cbBtInvert.Checked;
        }

        private void checkVersions()
        {

            lbVersion.Text = "Version: " + Program.CurrentVersion;
            if (ApplicationUpdater.CheckForNewerVersion())
            {
                lbNewVersion.Text = "(Update verfügbar!)";
                lbNewVersion.Enabled = true;
                lbNewVersion.DoubleClickEnabled = true;
                lbNewVersion.ToolTipText = "Doppelclick zum Updaten!";
                lbNewVersion.DoubleClick += LbNewVersion_DoubleClick;
                lbNewVersion.Click += LbNewVersion_DoubleClick;
                lbNewVersion.BackColor = Color.Green;
            }
            else
            {
                lbNewVersion.Text = "(aktuell)";
                lbNewVersion.Enabled = false;
            }

            lbVersionNo.Text = FirmwareUpdater.CheckForCurrentFirmwareVersion();
            if (lbVersionNo.Text != "")
                lbVersionNo.Text = "V" + lbVersionNo.Text;

            
            getComPorts();
        }

        public frmMain(string FileName)
        {
            InitializeComponent();
            checkVersions();

            CurrentFile = new CSC_File(FileName);
            lbFileName.Text = CurrentFile.FileName;
        }

        public frmMain()
        {
            InitializeComponent();
            checkVersions();
            if(Properties.Settings.Default.ChangeLogToShow != null && Properties.Settings.Default.ChangeLogToShow != "")
            {
                new frmChangelog(Properties.Settings.Default.ChangeLogToShow).ShowDialog();
                Properties.Settings.Default.ChangeLogToShow = "";
                Properties.Settings.Default.Save();
            }
            CurrentFile = new CSC_File();
            lbFileName.Text = CurrentFile.FileName;
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
                MessageBox.Show("Bitte schalten Sie während des Updatevorganges den PC nicht aus, " +
                    "schließen Sie nicht die Software und trennen Sie das Gerät nicht vom PC!\r\n\r\n" +
                    "Es können sonst irreparable Schäden am Gerät entstehen.");

                btCheckFirmware.Enabled = false;
                btUpload.Enabled = false;
                btFactoryReset.Enabled = false;
                btReadEEPROM.Enabled = false;

                btUpdateDevice.Text = "updating...";
                btUpdateDevice.Enabled = false;

                FirmwareUpdater Updater = new FirmwareUpdater();
                Updater.UpdateComplete += Updater_UpdateComplete;
                switch (AVR_Identifier.GetDeviceName(cbComPorts.Text).ToUpper())
                {
                    case "ATMEGA328P":
                        System.Threading.Thread.Sleep(500);
                        Updater.UpdateFirmware(cbComPorts.Text, false);
                        break;
                    case "ATMEGA328PB":
                        System.Threading.Thread.Sleep(500);
                        Updater.UpdateFirmware(cbComPorts.Text, true);
                        break;
                    default:
                        MessageBox.Show("Unbekannte Gerätesignatur!\r\n" + AVR_Identifier.GetDeviceSignature(cbComPorts.Text));
                        break;
                }
                
            }
            else
                MessageBox.Show("Bitte zuerst einen Port auswählen!");
        }

        private void Updater_UpdateComplete(FirmwareUpdater.UpdateCompleteEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                btUpdateDevice.Text = "Update";
                btCheckFirmware.Enabled = true;
                btUpdateDevice.Enabled = true;
                btUpload.Enabled = true;
                btFactoryReset.Enabled = true;
                btReadEEPROM.Enabled = true;
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
                btFactoryReset.Enabled = false;
                btReadEEPROM.Enabled = false;

                writeValues();
                SettingsUploader uploader = new SettingsUploader(cbComPorts.Text, _currentFile);
                uploader.Upload();

                btCheckFirmware.Enabled = true;
                btUpdateDevice.Enabled = true;
                btUpload.Enabled = true;
                btFactoryReset.Enabled = true;
                btReadEEPROM.Enabled = true;

            }
            else
                MessageBox.Show("Bitte zuerst einen Port auswählen!");
        }

        private void btCheckFirmware_Click(object sender, EventArgs e)
        {
            if (cbComPorts.Text != "")
            {
                btCheckFirmware.Enabled = false;
                btUpdateDevice.Enabled = false;
                btUpload.Enabled = false;
                btFactoryReset.Enabled = false;
                btReadEEPROM.Enabled = false;


                string version = FirmwareUpdater.GetDeviceVersion(cbComPorts.Text);
                if (version != "")
                    lbDeviceVersion.Text = "V" + version.Replace("<VERSION>", "").Replace("</VERSION>", "");

                string config = FirmwareUpdater.GetDeviceConfig(cbComPorts.Text);

                if(config.Contains("<CONFIG>") == false)
                {
                    MessageBox.Show("Error communicating, please try again!");
                    btCheckFirmware.Enabled = true;
                    btUpdateDevice.Enabled = true;
                    btUpload.Enabled = true;
                    btFactoryReset.Enabled = true;
                    btReadEEPROM.Enabled = true;
                    return;
                }

                config = config.ToUpper().Replace("<CONFIG>", "").Replace("</CONFIG>", "").Replace("\r\n","");
                CurrentFile = new CSC_File();

                string[] values = config.Split(':');
                cbEnableLimiter.Checked = values[0] == "1";
                ncLimiterFront.Value = HexPsiToDoubleBar(values[1]);
                ncLimiterRear.Value = HexPsiToDoubleBar(values[2]);

                cbEnableHighPressureAlarm.Checked = values[3] == "1";
                ncHighAlarmFront.Value = HexPsiToDoubleBar(values[4]);
                ncHighAlarmRear.Value = HexPsiToDoubleBar(values[5]);

                cbEnableLowPressureAlarm.Checked = values[6] == "1";
                ncLowAlarmFront.Value = HexPsiToDoubleBar(values[7]);
                ncLowAlarmRear.Value = HexPsiToDoubleBar(values[8]);

                cbRiseOnStart.Checked = values[9] == "1";

                btCheckFirmware.Enabled = true;
                btUpdateDevice.Enabled = true;
                btUpload.Enabled = true;
                btFactoryReset.Enabled = true;
                btReadEEPROM.Enabled = true;

            }
            else
                MessageBox.Show("Bitte zuerst einen Port auswählen!");
        }

        private decimal HexPsiToDoubleBar(string hex)
        {
            int iValue = Convert.ToInt32(hex, 16);
            decimal bar = (decimal)iValue * (decimal)(1.00 / CSC_File.barToPsi);
            bar = Math.Round(bar, 1);

            return bar;
        }

        private void btFactoryReset_Click(object sender, EventArgs e)
        {
            if (cbComPorts.Text != "")
            {
                btCheckFirmware.Enabled = false;
                btUpdateDevice.Enabled = false;
                btUpload.Enabled = false;
                btFactoryReset.Enabled = false;
                btReadEEPROM.Enabled = false;


                FirmwareUpdater.PerformFactoryReset(cbComPorts.Text);

                btCheckFirmware.Enabled = true;
                btUpdateDevice.Enabled = true;
                btUpload.Enabled = true;
                btReadEEPROM.Enabled = true;
                btFactoryReset.Enabled = true;
            }
            else
                MessageBox.Show("Bitte zuerst einen Port auswählen!");
        }

        private void btReadEEPROM_Click(object sender, EventArgs e)
        {
            if (cbComPorts.Text != "")
            {
                btCheckFirmware.Enabled = false;
                btUpdateDevice.Enabled = false;
                btUpload.Enabled = false;
                btFactoryReset.Enabled = false;
                btReadEEPROM.Enabled = false;


                string EEPROM_XML = FirmwareUpdater.GetDeviceEEPROM(cbComPorts.Text);
                if(EEPROM_XML != "")
                {
                    SaveFileDialog SFD = new SaveFileDialog();
                    SFD.Filter = "XML-Files (*.XML)|*.XML";
                    SFD.RestoreDirectory = true;
                    if (SFD.ShowDialog() == DialogResult.OK)
                        System.IO.File.WriteAllText(SFD.FileName, EEPROM_XML);
                }
                btCheckFirmware.Enabled = true;
                btUpdateDevice.Enabled = true;
                btUpload.Enabled = true;
                btReadEEPROM.Enabled = true;
                btFactoryReset.Enabled = true;
            }
            else
                MessageBox.Show("Bitte zuerst einen Port auswählen!");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
