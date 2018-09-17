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

            lbVersion.Text = "Version: " + Program.DB_VERSION_NO;
            lbNewVersion.Text = ApplicationUpdater.CheckForNewerVersion()? "(Update available!)" : "(Up to date)";

            _currentFile = new CSC_File();
            addDatabindings();

            _bsCurrentFile.DataSource = _currentFile;
            getComPorts();
        }

        void addDatabindings()
        {
            _bsCurrentFile = new BindingSource { DataSource = typeof(CSC_File) };

            ncLimitFL.DataBindings.Add("Value", _bsCurrentFile, "LimitFL");
            ncLimitFR.DataBindings.Add("Value", _bsCurrentFile, "LimitFR");
            ncLimitRL.DataBindings.Add("Value", _bsCurrentFile, "LimitRL");
            ncLimitRR.DataBindings.Add("Value", _bsCurrentFile, "LimitRR");

            cbEnableHighPressureAlarm.DataBindings.Add("Checked", _bsCurrentFile, "EnableHighBeep");
            ncHighAlarmFL.DataBindings.Add("Value", _bsCurrentFile, "HighBeepFL");
            ncHighAlarmFR.DataBindings.Add("Value", _bsCurrentFile, "HighBeepFR");
            ncHighAlarmRL.DataBindings.Add("Value", _bsCurrentFile, "HighBeepRL");
            ncHighAlarmRR.DataBindings.Add("Value", _bsCurrentFile, "HighBeepRR");

            cbEnableLowPressureAlarm.DataBindings.Add("Checked", _bsCurrentFile, "EnableLowBeep");
            ncLowAlarmFL.DataBindings.Add("Value", _bsCurrentFile, "LowBeepFL");
            ncLowAlarmFR.DataBindings.Add("Value", _bsCurrentFile, "LowBeepFR");
            ncLowAlarmRL.DataBindings.Add("Value", _bsCurrentFile, "LowBeepRL");
            ncLowAlarmRR.DataBindings.Add("Value", _bsCurrentFile, "LowBeepRR");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentFile = new CSC_File();
            _bsCurrentFile.DataSource = _currentFile;
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
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentFile.FileName = "";
            if (this.ActiveControl.DataBindings.Count > 0)
                this.ActiveControl.DataBindings[0].WriteValue();
            _currentFile.Save();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl.DataBindings.Count > 0)
                this.ActiveControl.DataBindings[0].WriteValue();
            _currentFile.Save();
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
    }
}
