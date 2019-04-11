namespace CruiseSafeCompanion
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.sTool = new System.Windows.Forms.ToolStrip();
            this.tsbtFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbPort = new System.Windows.Forms.ToolStripLabel();
            this.cbComPorts = new System.Windows.Forms.ToolStripComboBox();
            this.btRefresh = new System.Windows.Forms.ToolStripButton();
            this.btUpload = new System.Windows.Forms.ToolStripButton();
            this.btCheckFirmware = new System.Windows.Forms.ToolStripButton();
            this.btReadEEPROM = new System.Windows.Forms.ToolStripButton();
            this.sStatus = new System.Windows.Forms.StatusStrip();
            this.lbVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbNewVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpPressureLimits = new System.Windows.Forms.GroupBox();
            this.cbEnableLimiter = new System.Windows.Forms.CheckBox();
            this.lbLimitInfo = new System.Windows.Forms.Label();
            this.lbLimitRL = new System.Windows.Forms.Label();
            this.ncLimiterRear = new System.Windows.Forms.NumericUpDown();
            this.lbLimitFL = new System.Windows.Forms.Label();
            this.ncLimiterFront = new System.Windows.Forms.NumericUpDown();
            this.gpLowPressureBeep = new System.Windows.Forms.GroupBox();
            this.cbEnableLowPressureAlarm = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ncLowAlarmRear = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.ncLowAlarmFront = new System.Windows.Forms.NumericUpDown();
            this.gpHighPressureAlarm = new System.Windows.Forms.GroupBox();
            this.cbEnableHighPressureAlarm = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ncHighAlarmRear = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.ncHighAlarmFront = new System.Windows.Forms.NumericUpDown();
            this.gpFirmware = new System.Windows.Forms.GroupBox();
            this.btFactoryReset = new System.Windows.Forms.Button();
            this.btUpdateDevice = new System.Windows.Forms.Button();
            this.lbDeviceVersion = new System.Windows.Forms.Label();
            this.lbYourDevice = new System.Windows.Forms.Label();
            this.lbVersionNo = new System.Windows.Forms.Label();
            this.lbFirmwareDBVersion = new System.Windows.Forms.Label();
            this.cbRiseOnStart = new System.Windows.Forms.CheckBox();
            this.sTool.SuspendLayout();
            this.sStatus.SuspendLayout();
            this.gpPressureLimits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncLimiterRear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLimiterFront)).BeginInit();
            this.gpLowPressureBeep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncLowAlarmRear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLowAlarmFront)).BeginInit();
            this.gpHighPressureAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncHighAlarmRear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncHighAlarmFront)).BeginInit();
            this.gpFirmware.SuspendLayout();
            this.SuspendLayout();
            // 
            // sTool
            // 
            this.sTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtFile,
            this.btSave,
            this.toolStripSeparator1,
            this.lbPort,
            this.cbComPorts,
            this.btRefresh,
            this.btUpload,
            this.btCheckFirmware,
            this.btReadEEPROM});
            this.sTool.Location = new System.Drawing.Point(0, 0);
            this.sTool.Name = "sTool";
            this.sTool.Size = new System.Drawing.Size(448, 25);
            this.sTool.TabIndex = 0;
            this.sTool.Text = "toolStrip1";
            // 
            // tsbtFile
            // 
            this.tsbtFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.tsbtFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbtFile.Image")));
            this.tsbtFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtFile.Name = "tsbtFile";
            this.tsbtFile.Size = new System.Drawing.Size(63, 22);
            this.tsbtFile.Text = "Datei";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.newToolStripMenuItem.Text = "Neu";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.openToolStripMenuItem.Text = "Öffnen";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveAsToolStripMenuItem.Text = "Speichern unter";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveToolStripMenuItem.Text = "Speichern";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // btSave
            // 
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(79, 22);
            this.btSave.Text = "Speichern";
            this.btSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lbPort
            // 
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(32, 22);
            this.lbPort.Text = "Port:";
            // 
            // cbComPorts
            // 
            this.cbComPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComPorts.Name = "cbComPorts";
            this.cbComPorts.Size = new System.Drawing.Size(90, 25);
            // 
            // btRefresh
            // 
            this.btRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btRefresh.Image")));
            this.btRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(23, 22);
            this.btRefresh.Text = "Refresh";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btUpload
            // 
            this.btUpload.Image = ((System.Drawing.Image)(resources.GetObject("btUpload.Image")));
            this.btUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(65, 22);
            this.btUpload.Text = "Upload";
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // btCheckFirmware
            // 
            this.btCheckFirmware.Image = ((System.Drawing.Image)(resources.GetObject("btCheckFirmware.Image")));
            this.btCheckFirmware.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btCheckFirmware.Name = "btCheckFirmware";
            this.btCheckFirmware.Size = new System.Drawing.Size(60, 22);
            this.btCheckFirmware.Text = "Check";
            this.btCheckFirmware.Click += new System.EventHandler(this.btCheckFirmware_Click);
            // 
            // btReadEEPROM
            // 
            this.btReadEEPROM.Image = ((System.Drawing.Image)(resources.GetObject("btReadEEPROM.Image")));
            this.btReadEEPROM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btReadEEPROM.Name = "btReadEEPROM";
            this.btReadEEPROM.Size = new System.Drawing.Size(102, 20);
            this.btReadEEPROM.Text = "Read EEPROM";
            this.btReadEEPROM.Click += new System.EventHandler(this.btReadEEPROM_Click);
            // 
            // sStatus
            // 
            this.sStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbVersion,
            this.lbNewVersion,
            this.lbFile,
            this.lbFileName});
            this.sStatus.Location = new System.Drawing.Point(0, 453);
            this.sStatus.Name = "sStatus";
            this.sStatus.Size = new System.Drawing.Size(448, 22);
            this.sStatus.TabIndex = 1;
            this.sStatus.Text = "Version: 0.0";
            // 
            // lbVersion
            // 
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(66, 17);
            this.lbVersion.Text = "Version: 0.0";
            // 
            // lbNewVersion
            // 
            this.lbNewVersion.Name = "lbNewVersion";
            this.lbNewVersion.Size = new System.Drawing.Size(50, 17);
            this.lbNewVersion.Text = "(aktuell)";
            // 
            // lbFile
            // 
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(43, 17);
            this.lbFile.Text = "| Datei:";
            // 
            // lbFileName
            // 
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(64, 17);
            this.lbFileName.Text = "Dateiname";
            // 
            // gpPressureLimits
            // 
            this.gpPressureLimits.Controls.Add(this.cbEnableLimiter);
            this.gpPressureLimits.Controls.Add(this.lbLimitInfo);
            this.gpPressureLimits.Controls.Add(this.lbLimitRL);
            this.gpPressureLimits.Controls.Add(this.ncLimiterRear);
            this.gpPressureLimits.Controls.Add(this.lbLimitFL);
            this.gpPressureLimits.Controls.Add(this.ncLimiterFront);
            this.gpPressureLimits.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPressureLimits.Location = new System.Drawing.Point(12, 28);
            this.gpPressureLimits.Name = "gpPressureLimits";
            this.gpPressureLimits.Size = new System.Drawing.Size(211, 191);
            this.gpPressureLimits.TabIndex = 11;
            this.gpPressureLimits.TabStop = false;
            this.gpPressureLimits.Text = "Begrenzer";
            // 
            // cbEnableLimiter
            // 
            this.cbEnableLimiter.AutoSize = true;
            this.cbEnableLimiter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnableLimiter.Location = new System.Drawing.Point(67, 37);
            this.cbEnableLimiter.Name = "cbEnableLimiter";
            this.cbEnableLimiter.Size = new System.Drawing.Size(64, 23);
            this.cbEnableLimiter.TabIndex = 1;
            this.cbEnableLimiter.Text = "Aktiv";
            this.cbEnableLimiter.UseVisualStyleBackColor = true;
            // 
            // lbLimitInfo
            // 
            this.lbLimitInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLimitInfo.Location = new System.Drawing.Point(6, 129);
            this.lbLimitInfo.Name = "lbLimitInfo";
            this.lbLimitInfo.Size = new System.Drawing.Size(199, 59);
            this.lbLimitInfo.TabIndex = 19;
            this.lbLimitInfo.Text = "Minimaler Balgdruck in [bar]";
            this.lbLimitInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLimitRL
            // 
            this.lbLimitRL.AutoSize = true;
            this.lbLimitRL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLimitRL.Location = new System.Drawing.Point(6, 101);
            this.lbLimitRL.Name = "lbLimitRL";
            this.lbLimitRL.Size = new System.Drawing.Size(55, 19);
            this.lbLimitRL.TabIndex = 16;
            this.lbLimitRL.Text = "Hinten";
            // 
            // ncLimiterRear
            // 
            this.ncLimiterRear.DecimalPlaces = 1;
            this.ncLimiterRear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncLimiterRear.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncLimiterRear.Location = new System.Drawing.Point(67, 99);
            this.ncLimiterRear.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncLimiterRear.Name = "ncLimiterRear";
            this.ncLimiterRear.Size = new System.Drawing.Size(138, 27);
            this.ncLimiterRear.TabIndex = 3;
            this.ncLimiterRear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ncLimiterRear.Enter += new System.EventHandler(this.comboboxGotFocus);
            // 
            // lbLimitFL
            // 
            this.lbLimitFL.AutoSize = true;
            this.lbLimitFL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLimitFL.Location = new System.Drawing.Point(10, 68);
            this.lbLimitFL.Name = "lbLimitFL";
            this.lbLimitFL.Size = new System.Drawing.Size(51, 19);
            this.lbLimitFL.TabIndex = 12;
            this.lbLimitFL.Text = "Vorne";
            // 
            // ncLimiterFront
            // 
            this.ncLimiterFront.DecimalPlaces = 1;
            this.ncLimiterFront.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncLimiterFront.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncLimiterFront.Location = new System.Drawing.Point(67, 66);
            this.ncLimiterFront.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncLimiterFront.Name = "ncLimiterFront";
            this.ncLimiterFront.Size = new System.Drawing.Size(138, 27);
            this.ncLimiterFront.TabIndex = 2;
            this.ncLimiterFront.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ncLimiterFront.Enter += new System.EventHandler(this.comboboxGotFocus);
            // 
            // gpLowPressureBeep
            // 
            this.gpLowPressureBeep.Controls.Add(this.cbEnableLowPressureAlarm);
            this.gpLowPressureBeep.Controls.Add(this.label1);
            this.gpLowPressureBeep.Controls.Add(this.label3);
            this.gpLowPressureBeep.Controls.Add(this.ncLowAlarmRear);
            this.gpLowPressureBeep.Controls.Add(this.label5);
            this.gpLowPressureBeep.Controls.Add(this.ncLowAlarmFront);
            this.gpLowPressureBeep.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpLowPressureBeep.Location = new System.Drawing.Point(12, 225);
            this.gpLowPressureBeep.Name = "gpLowPressureBeep";
            this.gpLowPressureBeep.Size = new System.Drawing.Size(211, 191);
            this.gpLowPressureBeep.TabIndex = 12;
            this.gpLowPressureBeep.TabStop = false;
            this.gpLowPressureBeep.Text = "Unterdruck Alarm";
            // 
            // cbEnableLowPressureAlarm
            // 
            this.cbEnableLowPressureAlarm.AutoSize = true;
            this.cbEnableLowPressureAlarm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnableLowPressureAlarm.Location = new System.Drawing.Point(67, 37);
            this.cbEnableLowPressureAlarm.Name = "cbEnableLowPressureAlarm";
            this.cbEnableLowPressureAlarm.Size = new System.Drawing.Size(64, 23);
            this.cbEnableLowPressureAlarm.TabIndex = 4;
            this.cbEnableLowPressureAlarm.Text = "Aktiv";
            this.cbEnableLowPressureAlarm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 59);
            this.label1.TabIndex = 19;
            this.label1.Text = "Untere Druckschwelle für Alarm in [bar]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hinten";
            // 
            // ncLowAlarmRear
            // 
            this.ncLowAlarmRear.DecimalPlaces = 1;
            this.ncLowAlarmRear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncLowAlarmRear.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncLowAlarmRear.Location = new System.Drawing.Point(67, 99);
            this.ncLowAlarmRear.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncLowAlarmRear.Name = "ncLowAlarmRear";
            this.ncLowAlarmRear.Size = new System.Drawing.Size(138, 27);
            this.ncLowAlarmRear.TabIndex = 6;
            this.ncLowAlarmRear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ncLowAlarmRear.Enter += new System.EventHandler(this.comboboxGotFocus);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vorne";
            // 
            // ncLowAlarmFront
            // 
            this.ncLowAlarmFront.DecimalPlaces = 1;
            this.ncLowAlarmFront.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncLowAlarmFront.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncLowAlarmFront.Location = new System.Drawing.Point(67, 66);
            this.ncLowAlarmFront.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncLowAlarmFront.Name = "ncLowAlarmFront";
            this.ncLowAlarmFront.Size = new System.Drawing.Size(138, 27);
            this.ncLowAlarmFront.TabIndex = 5;
            this.ncLowAlarmFront.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ncLowAlarmFront.Enter += new System.EventHandler(this.comboboxGotFocus);
            // 
            // gpHighPressureAlarm
            // 
            this.gpHighPressureAlarm.Controls.Add(this.cbEnableHighPressureAlarm);
            this.gpHighPressureAlarm.Controls.Add(this.label6);
            this.gpHighPressureAlarm.Controls.Add(this.label8);
            this.gpHighPressureAlarm.Controls.Add(this.ncHighAlarmRear);
            this.gpHighPressureAlarm.Controls.Add(this.label10);
            this.gpHighPressureAlarm.Controls.Add(this.ncHighAlarmFront);
            this.gpHighPressureAlarm.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpHighPressureAlarm.Location = new System.Drawing.Point(229, 225);
            this.gpHighPressureAlarm.Name = "gpHighPressureAlarm";
            this.gpHighPressureAlarm.Size = new System.Drawing.Size(211, 191);
            this.gpHighPressureAlarm.TabIndex = 13;
            this.gpHighPressureAlarm.TabStop = false;
            this.gpHighPressureAlarm.Text = "Überdruck Alarm";
            // 
            // cbEnableHighPressureAlarm
            // 
            this.cbEnableHighPressureAlarm.AutoSize = true;
            this.cbEnableHighPressureAlarm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnableHighPressureAlarm.Location = new System.Drawing.Point(64, 37);
            this.cbEnableHighPressureAlarm.Name = "cbEnableHighPressureAlarm";
            this.cbEnableHighPressureAlarm.Size = new System.Drawing.Size(64, 23);
            this.cbEnableHighPressureAlarm.TabIndex = 7;
            this.cbEnableHighPressureAlarm.Text = "Aktiv";
            this.cbEnableHighPressureAlarm.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 59);
            this.label6.TabIndex = 19;
            this.label6.Text = "Obere Druckschwelle für Alarm in [bar]";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Hinten";
            // 
            // ncHighAlarmRear
            // 
            this.ncHighAlarmRear.DecimalPlaces = 1;
            this.ncHighAlarmRear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncHighAlarmRear.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncHighAlarmRear.Location = new System.Drawing.Point(67, 99);
            this.ncHighAlarmRear.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncHighAlarmRear.Name = "ncHighAlarmRear";
            this.ncHighAlarmRear.Size = new System.Drawing.Size(138, 27);
            this.ncHighAlarmRear.TabIndex = 9;
            this.ncHighAlarmRear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ncHighAlarmRear.Enter += new System.EventHandler(this.comboboxGotFocus);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Vorne";
            // 
            // ncHighAlarmFront
            // 
            this.ncHighAlarmFront.DecimalPlaces = 1;
            this.ncHighAlarmFront.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncHighAlarmFront.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncHighAlarmFront.Location = new System.Drawing.Point(67, 66);
            this.ncHighAlarmFront.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncHighAlarmFront.Name = "ncHighAlarmFront";
            this.ncHighAlarmFront.Size = new System.Drawing.Size(138, 27);
            this.ncHighAlarmFront.TabIndex = 8;
            this.ncHighAlarmFront.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ncHighAlarmFront.Enter += new System.EventHandler(this.comboboxGotFocus);
            // 
            // gpFirmware
            // 
            this.gpFirmware.Controls.Add(this.btFactoryReset);
            this.gpFirmware.Controls.Add(this.btUpdateDevice);
            this.gpFirmware.Controls.Add(this.lbDeviceVersion);
            this.gpFirmware.Controls.Add(this.lbYourDevice);
            this.gpFirmware.Controls.Add(this.lbVersionNo);
            this.gpFirmware.Controls.Add(this.lbFirmwareDBVersion);
            this.gpFirmware.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpFirmware.Location = new System.Drawing.Point(229, 28);
            this.gpFirmware.Name = "gpFirmware";
            this.gpFirmware.Size = new System.Drawing.Size(211, 191);
            this.gpFirmware.TabIndex = 14;
            this.gpFirmware.TabStop = false;
            this.gpFirmware.Text = "CS3.0 Firmware";
            // 
            // btFactoryReset
            // 
            this.btFactoryReset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFactoryReset.Location = new System.Drawing.Point(5, 155);
            this.btFactoryReset.Name = "btFactoryReset";
            this.btFactoryReset.Size = new System.Drawing.Size(199, 30);
            this.btFactoryReset.TabIndex = 100;
            this.btFactoryReset.Text = "Werksreset";
            this.btFactoryReset.UseVisualStyleBackColor = true;
            this.btFactoryReset.Click += new System.EventHandler(this.btFactoryReset_Click);
            // 
            // btUpdateDevice
            // 
            this.btUpdateDevice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateDevice.Location = new System.Drawing.Point(5, 120);
            this.btUpdateDevice.Name = "btUpdateDevice";
            this.btUpdateDevice.Size = new System.Drawing.Size(199, 30);
            this.btUpdateDevice.TabIndex = 99;
            this.btUpdateDevice.Text = "Update";
            this.btUpdateDevice.UseVisualStyleBackColor = true;
            this.btUpdateDevice.Click += new System.EventHandler(this.btUpdateDevice_Click);
            // 
            // lbDeviceVersion
            // 
            this.lbDeviceVersion.AutoSize = true;
            this.lbDeviceVersion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeviceVersion.Location = new System.Drawing.Point(162, 66);
            this.lbDeviceVersion.Name = "lbDeviceVersion";
            this.lbDeviceVersion.Size = new System.Drawing.Size(15, 19);
            this.lbDeviceVersion.TabIndex = 3;
            this.lbDeviceVersion.Text = "-";
            // 
            // lbYourDevice
            // 
            this.lbYourDevice.AutoSize = true;
            this.lbYourDevice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYourDevice.Location = new System.Drawing.Point(6, 66);
            this.lbYourDevice.Name = "lbYourDevice";
            this.lbYourDevice.Size = new System.Drawing.Size(150, 19);
            this.lbYourDevice.TabIndex = 2;
            this.lbYourDevice.Text = "Dein CRUISE-SAFE:";
            // 
            // lbVersionNo
            // 
            this.lbVersionNo.AutoSize = true;
            this.lbVersionNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersionNo.Location = new System.Drawing.Point(162, 38);
            this.lbVersionNo.Name = "lbVersionNo";
            this.lbVersionNo.Size = new System.Drawing.Size(42, 19);
            this.lbVersionNo.TabIndex = 1;
            this.lbVersionNo.Text = "V0.0";
            // 
            // lbFirmwareDBVersion
            // 
            this.lbFirmwareDBVersion.AutoSize = true;
            this.lbFirmwareDBVersion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirmwareDBVersion.Location = new System.Drawing.Point(37, 38);
            this.lbFirmwareDBVersion.Name = "lbFirmwareDBVersion";
            this.lbFirmwareDBVersion.Size = new System.Drawing.Size(119, 19);
            this.lbFirmwareDBVersion.TabIndex = 0;
            this.lbFirmwareDBVersion.Text = "Online Version:";
            // 
            // cbRiseOnStart
            // 
            this.cbRiseOnStart.AutoSize = true;
            this.cbRiseOnStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRiseOnStart.Location = new System.Drawing.Point(12, 422);
            this.cbRiseOnStart.Name = "cbRiseOnStart";
            this.cbRiseOnStart.Size = new System.Drawing.Size(116, 23);
            this.cbRiseOnStart.TabIndex = 10;
            this.cbRiseOnStart.Text = "Rise on start";
            this.cbRiseOnStart.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 475);
            this.Controls.Add(this.cbRiseOnStart);
            this.Controls.Add(this.gpFirmware);
            this.Controls.Add(this.gpHighPressureAlarm);
            this.Controls.Add(this.gpLowPressureBeep);
            this.Controls.Add(this.gpPressureLimits);
            this.Controls.Add(this.sStatus);
            this.Controls.Add(this.sTool);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cruise Safe Companion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.sTool.ResumeLayout(false);
            this.sTool.PerformLayout();
            this.sStatus.ResumeLayout(false);
            this.sStatus.PerformLayout();
            this.gpPressureLimits.ResumeLayout(false);
            this.gpPressureLimits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncLimiterRear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLimiterFront)).EndInit();
            this.gpLowPressureBeep.ResumeLayout(false);
            this.gpLowPressureBeep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncLowAlarmRear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLowAlarmFront)).EndInit();
            this.gpHighPressureAlarm.ResumeLayout(false);
            this.gpHighPressureAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncHighAlarmRear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncHighAlarmFront)).EndInit();
            this.gpFirmware.ResumeLayout(false);
            this.gpFirmware.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip sTool;
        private System.Windows.Forms.StatusStrip sStatus;
        private System.Windows.Forms.ToolStripStatusLabel lbVersion;
        private System.Windows.Forms.ToolStripStatusLabel lbNewVersion;
        private System.Windows.Forms.ToolStripDropDownButton tsbtFile;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpPressureLimits;
        private System.Windows.Forms.Label lbLimitInfo;
        private System.Windows.Forms.Label lbLimitRL;
        private System.Windows.Forms.NumericUpDown ncLimiterRear;
        private System.Windows.Forms.Label lbLimitFL;
        private System.Windows.Forms.NumericUpDown ncLimiterFront;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripComboBox cbComPorts;
        private System.Windows.Forms.ToolStripButton btUpload;
        private System.Windows.Forms.ToolStripButton btRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lbPort;
        private System.Windows.Forms.GroupBox gpLowPressureBeep;
        private System.Windows.Forms.CheckBox cbEnableLowPressureAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ncLowAlarmRear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ncLowAlarmFront;
        private System.Windows.Forms.GroupBox gpHighPressureAlarm;
        private System.Windows.Forms.CheckBox cbEnableHighPressureAlarm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ncHighAlarmRear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown ncHighAlarmFront;
        private System.Windows.Forms.CheckBox cbEnableLimiter;
        private System.Windows.Forms.GroupBox gpFirmware;
        private System.Windows.Forms.Label lbFirmwareDBVersion;
        private System.Windows.Forms.Label lbVersionNo;
        private System.Windows.Forms.Button btUpdateDevice;
        private System.Windows.Forms.Label lbDeviceVersion;
        private System.Windows.Forms.Label lbYourDevice;
        private System.Windows.Forms.ToolStripButton btCheckFirmware;
        private System.Windows.Forms.CheckBox cbRiseOnStart;
        private System.Windows.Forms.ToolStripStatusLabel lbFile;
        private System.Windows.Forms.ToolStripStatusLabel lbFileName;
        private System.Windows.Forms.Button btFactoryReset;
        private System.Windows.Forms.ToolStripButton btReadEEPROM;
    }
}

