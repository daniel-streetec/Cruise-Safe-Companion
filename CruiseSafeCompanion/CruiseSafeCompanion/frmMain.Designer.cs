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
            this.sStatus = new System.Windows.Forms.StatusStrip();
            this.lbVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbNewVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbtFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpPressureLimits = new System.Windows.Forms.GroupBox();
            this.lbLimitRR = new System.Windows.Forms.Label();
            this.ncLimitRR = new System.Windows.Forms.NumericUpDown();
            this.lbLimitRL = new System.Windows.Forms.Label();
            this.ncLimitRL = new System.Windows.Forms.NumericUpDown();
            this.lbLimitFR = new System.Windows.Forms.Label();
            this.ncLimitFR = new System.Windows.Forms.NumericUpDown();
            this.lbLimitFL = new System.Windows.Forms.Label();
            this.ncLimitFL = new System.Windows.Forms.NumericUpDown();
            this.lbLimitInfo = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.cbComPorts = new System.Windows.Forms.ToolStripComboBox();
            this.btUpload = new System.Windows.Forms.ToolStripButton();
            this.btRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbPort = new System.Windows.Forms.ToolStripLabel();
            this.gpLowPressureBeep = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ncLowAlarmRR = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ncLowAlarmRL = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ncLowAlarmFR = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.ncLowAlarmFL = new System.Windows.Forms.NumericUpDown();
            this.cbEnableLowPressureAlarm = new System.Windows.Forms.CheckBox();
            this.gpHighPressureAlarm = new System.Windows.Forms.GroupBox();
            this.cbEnableHighPressureAlarm = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ncHighAlarmRR = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ncHighAlarmRL = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.ncHighAlarmFR = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.ncHighAlarmFL = new System.Windows.Forms.NumericUpDown();
            this.sTool.SuspendLayout();
            this.sStatus.SuspendLayout();
            this.gpPressureLimits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncLimitRR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLimitRL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLimitFR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLimitFL)).BeginInit();
            this.gpLowPressureBeep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncLowAlarmRR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLowAlarmRL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLowAlarmFR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLowAlarmFL)).BeginInit();
            this.gpHighPressureAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncHighAlarmRR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncHighAlarmRL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncHighAlarmFR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncHighAlarmFL)).BeginInit();
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
            this.btUpload});
            this.sTool.Location = new System.Drawing.Point(0, 0);
            this.sTool.Name = "sTool";
            this.sTool.Size = new System.Drawing.Size(451, 25);
            this.sTool.TabIndex = 0;
            this.sTool.Text = "toolStrip1";
            // 
            // sStatus
            // 
            this.sStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbVersion,
            this.lbNewVersion});
            this.sStatus.Location = new System.Drawing.Point(0, 382);
            this.sStatus.Name = "sStatus";
            this.sStatus.Size = new System.Drawing.Size(451, 22);
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
            this.lbNewVersion.Size = new System.Drawing.Size(78, 17);
            this.lbNewVersion.Text = "(most recent)";
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
            this.tsbtFile.Size = new System.Drawing.Size(54, 22);
            this.tsbtFile.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // gpPressureLimits
            // 
            this.gpPressureLimits.Controls.Add(this.lbLimitInfo);
            this.gpPressureLimits.Controls.Add(this.lbLimitRR);
            this.gpPressureLimits.Controls.Add(this.ncLimitRR);
            this.gpPressureLimits.Controls.Add(this.lbLimitRL);
            this.gpPressureLimits.Controls.Add(this.ncLimitRL);
            this.gpPressureLimits.Controls.Add(this.lbLimitFR);
            this.gpPressureLimits.Controls.Add(this.ncLimitFR);
            this.gpPressureLimits.Controls.Add(this.lbLimitFL);
            this.gpPressureLimits.Controls.Add(this.ncLimitFL);
            this.gpPressureLimits.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPressureLimits.Location = new System.Drawing.Point(12, 28);
            this.gpPressureLimits.Name = "gpPressureLimits";
            this.gpPressureLimits.Size = new System.Drawing.Size(211, 154);
            this.gpPressureLimits.TabIndex = 11;
            this.gpPressureLimits.TabStop = false;
            this.gpPressureLimits.Text = "Pressure Limiter";
            // 
            // lbLimitRR
            // 
            this.lbLimitRR.AutoSize = true;
            this.lbLimitRR.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLimitRR.Location = new System.Drawing.Point(103, 64);
            this.lbLimitRR.Name = "lbLimitRR";
            this.lbLimitRR.Size = new System.Drawing.Size(29, 19);
            this.lbLimitRR.TabIndex = 18;
            this.lbLimitRR.Text = "RR";
            // 
            // ncLimitRR
            // 
            this.ncLimitRR.DecimalPlaces = 1;
            this.ncLimitRR.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncLimitRR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncLimitRR.Location = new System.Drawing.Point(134, 62);
            this.ncLimitRR.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncLimitRR.Name = "ncLimitRR";
            this.ncLimitRR.Size = new System.Drawing.Size(60, 27);
            this.ncLimitRR.TabIndex = 17;
            this.ncLimitRR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLimitRL
            // 
            this.lbLimitRL.AutoSize = true;
            this.lbLimitRL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLimitRL.Location = new System.Drawing.Point(5, 64);
            this.lbLimitRL.Name = "lbLimitRL";
            this.lbLimitRL.Size = new System.Drawing.Size(27, 19);
            this.lbLimitRL.TabIndex = 16;
            this.lbLimitRL.Text = "RL";
            // 
            // ncLimitRL
            // 
            this.ncLimitRL.DecimalPlaces = 1;
            this.ncLimitRL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncLimitRL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncLimitRL.Location = new System.Drawing.Point(37, 62);
            this.ncLimitRL.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncLimitRL.Name = "ncLimitRL";
            this.ncLimitRL.Size = new System.Drawing.Size(60, 27);
            this.ncLimitRL.TabIndex = 15;
            this.ncLimitRL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLimitFR
            // 
            this.lbLimitFR.AutoSize = true;
            this.lbLimitFR.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLimitFR.Location = new System.Drawing.Point(103, 31);
            this.lbLimitFR.Name = "lbLimitFR";
            this.lbLimitFR.Size = new System.Drawing.Size(27, 19);
            this.lbLimitFR.TabIndex = 14;
            this.lbLimitFR.Text = "FR";
            // 
            // ncLimitFR
            // 
            this.ncLimitFR.DecimalPlaces = 1;
            this.ncLimitFR.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncLimitFR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncLimitFR.Location = new System.Drawing.Point(134, 29);
            this.ncLimitFR.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncLimitFR.Name = "ncLimitFR";
            this.ncLimitFR.Size = new System.Drawing.Size(60, 27);
            this.ncLimitFR.TabIndex = 13;
            this.ncLimitFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLimitFL
            // 
            this.lbLimitFL.AutoSize = true;
            this.lbLimitFL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLimitFL.Location = new System.Drawing.Point(6, 31);
            this.lbLimitFL.Name = "lbLimitFL";
            this.lbLimitFL.Size = new System.Drawing.Size(25, 19);
            this.lbLimitFL.TabIndex = 12;
            this.lbLimitFL.Text = "FL";
            // 
            // ncLimitFL
            // 
            this.ncLimitFL.DecimalPlaces = 1;
            this.ncLimitFL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncLimitFL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncLimitFL.Location = new System.Drawing.Point(37, 29);
            this.ncLimitFL.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncLimitFL.Name = "ncLimitFL";
            this.ncLimitFL.Size = new System.Drawing.Size(60, 27);
            this.ncLimitFL.TabIndex = 11;
            this.ncLimitFL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLimitInfo
            // 
            this.lbLimitInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLimitInfo.Location = new System.Drawing.Point(6, 92);
            this.lbLimitInfo.Name = "lbLimitInfo";
            this.lbLimitInfo.Size = new System.Drawing.Size(199, 59);
            this.lbLimitInfo.TabIndex = 19;
            this.lbLimitInfo.Text = "Minimum Bag pressure for corresponding bag in bar";
            this.lbLimitInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSave
            // 
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(51, 22);
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // cbComPorts
            // 
            this.cbComPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComPorts.Name = "cbComPorts";
            this.cbComPorts.Size = new System.Drawing.Size(121, 25);
            // 
            // btUpload
            // 
            this.btUpload.Image = ((System.Drawing.Image)(resources.GetObject("btUpload.Image")));
            this.btUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(65, 22);
            this.btUpload.Text = "Upload";
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
            // gpLowPressureBeep
            // 
            this.gpLowPressureBeep.Controls.Add(this.cbEnableLowPressureAlarm);
            this.gpLowPressureBeep.Controls.Add(this.label1);
            this.gpLowPressureBeep.Controls.Add(this.label2);
            this.gpLowPressureBeep.Controls.Add(this.ncLowAlarmRR);
            this.gpLowPressureBeep.Controls.Add(this.label3);
            this.gpLowPressureBeep.Controls.Add(this.ncLowAlarmRL);
            this.gpLowPressureBeep.Controls.Add(this.label4);
            this.gpLowPressureBeep.Controls.Add(this.ncLowAlarmFR);
            this.gpLowPressureBeep.Controls.Add(this.label5);
            this.gpLowPressureBeep.Controls.Add(this.ncLowAlarmFL);
            this.gpLowPressureBeep.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpLowPressureBeep.Location = new System.Drawing.Point(12, 188);
            this.gpLowPressureBeep.Name = "gpLowPressureBeep";
            this.gpLowPressureBeep.Size = new System.Drawing.Size(211, 191);
            this.gpLowPressureBeep.TabIndex = 12;
            this.gpLowPressureBeep.TabStop = false;
            this.gpLowPressureBeep.Text = "Low Pressure Alarm";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 59);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lower threshold (alarm-)pressure for the corresponding bag in bar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "RR";
            // 
            // ncLowAlarmRR
            // 
            this.ncLowAlarmRR.DecimalPlaces = 1;
            this.ncLowAlarmRR.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncLowAlarmRR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncLowAlarmRR.Location = new System.Drawing.Point(134, 99);
            this.ncLowAlarmRR.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncLowAlarmRR.Name = "ncLowAlarmRR";
            this.ncLowAlarmRR.Size = new System.Drawing.Size(60, 27);
            this.ncLowAlarmRR.TabIndex = 17;
            this.ncLowAlarmRR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "RL";
            // 
            // ncLowAlarmRL
            // 
            this.ncLowAlarmRL.DecimalPlaces = 1;
            this.ncLowAlarmRL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncLowAlarmRL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncLowAlarmRL.Location = new System.Drawing.Point(37, 99);
            this.ncLowAlarmRL.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncLowAlarmRL.Name = "ncLowAlarmRL";
            this.ncLowAlarmRL.Size = new System.Drawing.Size(60, 27);
            this.ncLowAlarmRL.TabIndex = 15;
            this.ncLowAlarmRL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "FR";
            // 
            // ncLowAlarmFR
            // 
            this.ncLowAlarmFR.DecimalPlaces = 1;
            this.ncLowAlarmFR.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncLowAlarmFR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncLowAlarmFR.Location = new System.Drawing.Point(134, 66);
            this.ncLowAlarmFR.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncLowAlarmFR.Name = "ncLowAlarmFR";
            this.ncLowAlarmFR.Size = new System.Drawing.Size(60, 27);
            this.ncLowAlarmFR.TabIndex = 13;
            this.ncLowAlarmFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "FL";
            // 
            // ncLowAlarmFL
            // 
            this.ncLowAlarmFL.DecimalPlaces = 1;
            this.ncLowAlarmFL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncLowAlarmFL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncLowAlarmFL.Location = new System.Drawing.Point(37, 66);
            this.ncLowAlarmFL.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncLowAlarmFL.Name = "ncLowAlarmFL";
            this.ncLowAlarmFL.Size = new System.Drawing.Size(60, 27);
            this.ncLowAlarmFL.TabIndex = 11;
            this.ncLowAlarmFL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbEnableLowPressureAlarm
            // 
            this.cbEnableLowPressureAlarm.AutoSize = true;
            this.cbEnableLowPressureAlarm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnableLowPressureAlarm.Location = new System.Drawing.Point(10, 37);
            this.cbEnableLowPressureAlarm.Name = "cbEnableLowPressureAlarm";
            this.cbEnableLowPressureAlarm.Size = new System.Drawing.Size(120, 23);
            this.cbEnableLowPressureAlarm.TabIndex = 20;
            this.cbEnableLowPressureAlarm.Text = "Enable alarm";
            this.cbEnableLowPressureAlarm.UseVisualStyleBackColor = true;
            // 
            // gpHighPressureAlarm
            // 
            this.gpHighPressureAlarm.Controls.Add(this.cbEnableHighPressureAlarm);
            this.gpHighPressureAlarm.Controls.Add(this.label6);
            this.gpHighPressureAlarm.Controls.Add(this.label7);
            this.gpHighPressureAlarm.Controls.Add(this.ncHighAlarmRR);
            this.gpHighPressureAlarm.Controls.Add(this.label8);
            this.gpHighPressureAlarm.Controls.Add(this.ncHighAlarmRL);
            this.gpHighPressureAlarm.Controls.Add(this.label9);
            this.gpHighPressureAlarm.Controls.Add(this.ncHighAlarmFR);
            this.gpHighPressureAlarm.Controls.Add(this.label10);
            this.gpHighPressureAlarm.Controls.Add(this.ncHighAlarmFL);
            this.gpHighPressureAlarm.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpHighPressureAlarm.Location = new System.Drawing.Point(229, 188);
            this.gpHighPressureAlarm.Name = "gpHighPressureAlarm";
            this.gpHighPressureAlarm.Size = new System.Drawing.Size(211, 191);
            this.gpHighPressureAlarm.TabIndex = 13;
            this.gpHighPressureAlarm.TabStop = false;
            this.gpHighPressureAlarm.Text = "High Pressure Alarm";
            // 
            // cbEnableHighPressureAlarm
            // 
            this.cbEnableHighPressureAlarm.AutoSize = true;
            this.cbEnableHighPressureAlarm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnableHighPressureAlarm.Location = new System.Drawing.Point(10, 37);
            this.cbEnableHighPressureAlarm.Name = "cbEnableHighPressureAlarm";
            this.cbEnableHighPressureAlarm.Size = new System.Drawing.Size(120, 23);
            this.cbEnableHighPressureAlarm.TabIndex = 20;
            this.cbEnableHighPressureAlarm.Text = "Enable alarm";
            this.cbEnableHighPressureAlarm.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 59);
            this.label6.TabIndex = 19;
            this.label6.Text = "Upper threshold (alarm-)pressure for the corresponding bag in bar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "RR";
            // 
            // ncHighAlarmRR
            // 
            this.ncHighAlarmRR.DecimalPlaces = 1;
            this.ncHighAlarmRR.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncHighAlarmRR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncHighAlarmRR.Location = new System.Drawing.Point(134, 99);
            this.ncHighAlarmRR.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncHighAlarmRR.Name = "ncHighAlarmRR";
            this.ncHighAlarmRR.Size = new System.Drawing.Size(60, 27);
            this.ncHighAlarmRR.TabIndex = 17;
            this.ncHighAlarmRR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "RL";
            // 
            // ncHighAlarmRL
            // 
            this.ncHighAlarmRL.DecimalPlaces = 1;
            this.ncHighAlarmRL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncHighAlarmRL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncHighAlarmRL.Location = new System.Drawing.Point(37, 99);
            this.ncHighAlarmRL.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncHighAlarmRL.Name = "ncHighAlarmRL";
            this.ncHighAlarmRL.Size = new System.Drawing.Size(60, 27);
            this.ncHighAlarmRL.TabIndex = 15;
            this.ncHighAlarmRL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(103, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "FR";
            // 
            // ncHighAlarmFR
            // 
            this.ncHighAlarmFR.DecimalPlaces = 1;
            this.ncHighAlarmFR.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncHighAlarmFR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncHighAlarmFR.Location = new System.Drawing.Point(134, 66);
            this.ncHighAlarmFR.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncHighAlarmFR.Name = "ncHighAlarmFR";
            this.ncHighAlarmFR.Size = new System.Drawing.Size(60, 27);
            this.ncHighAlarmFR.TabIndex = 13;
            this.ncHighAlarmFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "FL";
            // 
            // ncHighAlarmFL
            // 
            this.ncHighAlarmFL.DecimalPlaces = 1;
            this.ncHighAlarmFL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncHighAlarmFL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ncHighAlarmFL.Location = new System.Drawing.Point(37, 66);
            this.ncHighAlarmFL.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncHighAlarmFL.Name = "ncHighAlarmFL";
            this.ncHighAlarmFL.Size = new System.Drawing.Size(60, 27);
            this.ncHighAlarmFL.TabIndex = 11;
            this.ncHighAlarmFL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 404);
            this.Controls.Add(this.gpHighPressureAlarm);
            this.Controls.Add(this.gpLowPressureBeep);
            this.Controls.Add(this.gpPressureLimits);
            this.Controls.Add(this.sStatus);
            this.Controls.Add(this.sTool);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cruise Safe Companion";
            this.sTool.ResumeLayout(false);
            this.sTool.PerformLayout();
            this.sStatus.ResumeLayout(false);
            this.sStatus.PerformLayout();
            this.gpPressureLimits.ResumeLayout(false);
            this.gpPressureLimits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncLimitRR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLimitRL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLimitFR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLimitFL)).EndInit();
            this.gpLowPressureBeep.ResumeLayout(false);
            this.gpLowPressureBeep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncLowAlarmRR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLowAlarmRL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLowAlarmFR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncLowAlarmFL)).EndInit();
            this.gpHighPressureAlarm.ResumeLayout(false);
            this.gpHighPressureAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncHighAlarmRR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncHighAlarmRL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncHighAlarmFR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncHighAlarmFL)).EndInit();
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
        private System.Windows.Forms.Label lbLimitRR;
        private System.Windows.Forms.NumericUpDown ncLimitRR;
        private System.Windows.Forms.Label lbLimitRL;
        private System.Windows.Forms.NumericUpDown ncLimitRL;
        private System.Windows.Forms.Label lbLimitFR;
        private System.Windows.Forms.NumericUpDown ncLimitFR;
        private System.Windows.Forms.Label lbLimitFL;
        private System.Windows.Forms.NumericUpDown ncLimitFL;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripComboBox cbComPorts;
        private System.Windows.Forms.ToolStripButton btUpload;
        private System.Windows.Forms.ToolStripButton btRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lbPort;
        private System.Windows.Forms.GroupBox gpLowPressureBeep;
        private System.Windows.Forms.CheckBox cbEnableLowPressureAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ncLowAlarmRR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ncLowAlarmRL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ncLowAlarmFR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ncLowAlarmFL;
        private System.Windows.Forms.GroupBox gpHighPressureAlarm;
        private System.Windows.Forms.CheckBox cbEnableHighPressureAlarm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ncHighAlarmRR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ncHighAlarmRL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown ncHighAlarmFR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown ncHighAlarmFL;
    }
}

