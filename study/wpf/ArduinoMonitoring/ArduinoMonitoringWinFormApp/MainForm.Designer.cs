namespace ArduinoMonitoringWinFormApp
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSubItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSubItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSubItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSubItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSubItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSubItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.LblConnectionTime = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtSensorCount = new MetroSet_UI.Controls.MetroSetTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPortValue = new MetroSet_UI.Controls.MetroSetButton();
            this.BtnDisconnect = new MetroSet_UI.Controls.MetroSetButton();
            this.BtnConnect = new MetroSet_UI.Controls.MetroSetButton();
            this.CboSerialPort = new MetroSet_UI.Controls.MetroSetComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblPhotoRegistor = new MetroSet_UI.Controls.MetroSetLabel();
            this.PgbPhotoRegistor = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.BtnViewAll = new MetroSet_UI.Controls.MetroSetButton();
            this.BtnZoom = new MetroSet_UI.Controls.MetroSetButton();
            this.ChtSensorValues = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RtbLog = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChtSensorValues)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.Location = new System.Drawing.Point(498, 2);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemSimulation,
            this.MenuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(12, 70);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(576, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSubItemOpen,
            this.MenuSubItemSave,
            this.toolStripSeparator1,
            this.MenuSubItemExit});
            this.MenuItemFile.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(51, 23);
            this.MenuItemFile.Text = "파일";
            // 
            // MenuSubItemOpen
            // 
            this.MenuSubItemOpen.Image = ((System.Drawing.Image)(resources.GetObject("MenuSubItemOpen.Image")));
            this.MenuSubItemOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSubItemOpen.Name = "MenuSubItemOpen";
            this.MenuSubItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuSubItemOpen.Size = new System.Drawing.Size(198, 24);
            this.MenuSubItemOpen.Text = "열기";
            // 
            // MenuSubItemSave
            // 
            this.MenuSubItemSave.Image = ((System.Drawing.Image)(resources.GetObject("MenuSubItemSave.Image")));
            this.MenuSubItemSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSubItemSave.Name = "MenuSubItemSave";
            this.MenuSubItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSubItemSave.Size = new System.Drawing.Size(198, 24);
            this.MenuSubItemSave.Text = "저장";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // MenuSubItemExit
            // 
            this.MenuSubItemExit.Name = "MenuSubItemExit";
            this.MenuSubItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuSubItemExit.Size = new System.Drawing.Size(198, 24);
            this.MenuSubItemExit.Text = "끝내기";
            this.MenuSubItemExit.Click += new System.EventHandler(this.MenuSubItemExit_Click);
            // 
            // MenuItemSimulation
            // 
            this.MenuItemSimulation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSubItemStart,
            this.MenuSubItemStop,
            this.toolStripSeparator3});
            this.MenuItemSimulation.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MenuItemSimulation.Name = "MenuItemSimulation";
            this.MenuItemSimulation.Size = new System.Drawing.Size(96, 23);
            this.MenuItemSimulation.Text = "시뮬레이션";
            // 
            // MenuSubItemStart
            // 
            this.MenuSubItemStart.Name = "MenuSubItemStart";
            this.MenuSubItemStart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.MenuSubItemStart.Size = new System.Drawing.Size(198, 24);
            this.MenuSubItemStart.Text = "시작";
            this.MenuSubItemStart.Click += new System.EventHandler(this.MenuSubItemStart_Click);
            // 
            // MenuSubItemStop
            // 
            this.MenuSubItemStop.Name = "MenuSubItemStop";
            this.MenuSubItemStop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.MenuSubItemStop.Size = new System.Drawing.Size(198, 24);
            this.MenuSubItemStop.Text = "중지";
            this.MenuSubItemStop.Click += new System.EventHandler(this.MenuSubItemStop_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(195, 6);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSubItemInfo});
            this.MenuItemHelp.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(66, 23);
            this.MenuItemHelp.Text = "도움말";
            // 
            // MenuSubItemInfo
            // 
            this.MenuSubItemInfo.Name = "MenuSubItemInfo";
            this.MenuSubItemInfo.Size = new System.Drawing.Size(133, 24);
            this.MenuSubItemInfo.Text = "정보...";
            this.MenuSubItemInfo.Click += new System.EventHandler(this.MenuSubItemInfo_Click);
            // 
            // LblConnectionTime
            // 
            this.LblConnectionTime.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConnectionTime.Location = new System.Drawing.Point(22, 117);
            this.LblConnectionTime.Name = "LblConnectionTime";
            this.LblConnectionTime.Size = new System.Drawing.Size(257, 23);
            this.LblConnectionTime.Style = MetroSet_UI.Design.Style.Light;
            this.LblConnectionTime.StyleManager = null;
            this.LblConnectionTime.TabIndex = 2;
            this.LblConnectionTime.Text = "연결시간 : ";
            this.LblConnectionTime.ThemeAuthor = "Narwin";
            this.LblConnectionTime.ThemeName = "MetroLite";
            // 
            // TxtSensorCount
            // 
            this.TxtSensorCount.AutoCompleteCustomSource = null;
            this.TxtSensorCount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtSensorCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtSensorCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TxtSensorCount.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TxtSensorCount.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TxtSensorCount.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.TxtSensorCount.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSensorCount.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.TxtSensorCount.Image = null;
            this.TxtSensorCount.Lines = null;
            this.TxtSensorCount.Location = new System.Drawing.Point(285, 113);
            this.TxtSensorCount.MaxLength = 32767;
            this.TxtSensorCount.Multiline = false;
            this.TxtSensorCount.Name = "TxtSensorCount";
            this.TxtSensorCount.ReadOnly = true;
            this.TxtSensorCount.Size = new System.Drawing.Size(114, 29);
            this.TxtSensorCount.Style = MetroSet_UI.Design.Style.Light;
            this.TxtSensorCount.StyleManager = null;
            this.TxtSensorCount.TabIndex = 3;
            this.TxtSensorCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtSensorCount.ThemeAuthor = "Narwin";
            this.TxtSensorCount.ThemeName = "MetroLite";
            this.TxtSensorCount.UseSystemPasswordChar = false;
            this.TxtSensorCount.WatermarkText = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.BtnPortValue);
            this.groupBox1.Controls.Add(this.BtnDisconnect);
            this.groupBox1.Controls.Add(this.BtnConnect);
            this.groupBox1.Controls.Add(this.CboSerialPort);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(411, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 252);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "포트";
            // 
            // BtnPortValue
            // 
            this.BtnPortValue.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnPortValue.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnPortValue.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnPortValue.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnPortValue.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnPortValue.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnPortValue.HoverTextColor = System.Drawing.Color.White;
            this.BtnPortValue.Location = new System.Drawing.Point(6, 148);
            this.BtnPortValue.Name = "BtnPortValue";
            this.BtnPortValue.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnPortValue.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnPortValue.NormalTextColor = System.Drawing.Color.White;
            this.BtnPortValue.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnPortValue.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnPortValue.PressTextColor = System.Drawing.Color.White;
            this.BtnPortValue.Size = new System.Drawing.Size(165, 98);
            this.BtnPortValue.Style = MetroSet_UI.Design.Style.Light;
            this.BtnPortValue.StyleManager = null;
            this.BtnPortValue.TabIndex = 1;
            this.BtnPortValue.Text = "Port";
            this.BtnPortValue.ThemeAuthor = "Narwin";
            this.BtnPortValue.ThemeName = "MetroLite";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnDisconnect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnDisconnect.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnDisconnect.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDisconnect.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnDisconnect.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnDisconnect.HoverTextColor = System.Drawing.Color.White;
            this.BtnDisconnect.Location = new System.Drawing.Point(6, 102);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnDisconnect.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnDisconnect.NormalTextColor = System.Drawing.Color.White;
            this.BtnDisconnect.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnDisconnect.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnDisconnect.PressTextColor = System.Drawing.Color.White;
            this.BtnDisconnect.Size = new System.Drawing.Size(165, 40);
            this.BtnDisconnect.Style = MetroSet_UI.Design.Style.Light;
            this.BtnDisconnect.StyleManager = null;
            this.BtnDisconnect.TabIndex = 1;
            this.BtnDisconnect.Text = "DISCONNECT";
            this.BtnDisconnect.ThemeAuthor = "Narwin";
            this.BtnDisconnect.ThemeName = "MetroLite";
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnConnect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnConnect.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnConnect.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnConnect.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnConnect.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnConnect.HoverTextColor = System.Drawing.Color.White;
            this.BtnConnect.Location = new System.Drawing.Point(6, 56);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnConnect.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnConnect.NormalTextColor = System.Drawing.Color.White;
            this.BtnConnect.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnConnect.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnConnect.PressTextColor = System.Drawing.Color.White;
            this.BtnConnect.Size = new System.Drawing.Size(165, 40);
            this.BtnConnect.Style = MetroSet_UI.Design.Style.Light;
            this.BtnConnect.StyleManager = null;
            this.BtnConnect.TabIndex = 1;
            this.BtnConnect.Text = "CONNECT";
            this.BtnConnect.ThemeAuthor = "Narwin";
            this.BtnConnect.ThemeName = "MetroLite";
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // CboSerialPort
            // 
            this.CboSerialPort.AllowDrop = true;
            this.CboSerialPort.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.CboSerialPort.BackColor = System.Drawing.Color.Transparent;
            this.CboSerialPort.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CboSerialPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.CboSerialPort.CausesValidation = false;
            this.CboSerialPort.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CboSerialPort.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.CboSerialPort.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.CboSerialPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CboSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSerialPort.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboSerialPort.FormattingEnabled = true;
            this.CboSerialPort.ItemHeight = 20;
            this.CboSerialPort.Location = new System.Drawing.Point(6, 24);
            this.CboSerialPort.Name = "CboSerialPort";
            this.CboSerialPort.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CboSerialPort.SelectedItemForeColor = System.Drawing.Color.White;
            this.CboSerialPort.Size = new System.Drawing.Size(165, 26);
            this.CboSerialPort.Style = MetroSet_UI.Design.Style.Light;
            this.CboSerialPort.StyleManager = null;
            this.CboSerialPort.TabIndex = 0;
            this.CboSerialPort.ThemeAuthor = "Narwin";
            this.CboSerialPort.ThemeName = "MetroLite";
            this.CboSerialPort.SelectedIndexChanged += new System.EventHandler(this.CboSerialPort_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.LblPhotoRegistor);
            this.groupBox2.Controls.Add(this.PgbPhotoRegistor);
            this.groupBox2.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 95);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "포토레지스터";
            // 
            // LblPhotoRegistor
            // 
            this.LblPhotoRegistor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblPhotoRegistor.Location = new System.Drawing.Point(146, 64);
            this.LblPhotoRegistor.Name = "LblPhotoRegistor";
            this.LblPhotoRegistor.Size = new System.Drawing.Size(100, 23);
            this.LblPhotoRegistor.Style = MetroSet_UI.Design.Style.Light;
            this.LblPhotoRegistor.StyleManager = null;
            this.LblPhotoRegistor.TabIndex = 1;
            this.LblPhotoRegistor.Text = "0";
            this.LblPhotoRegistor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblPhotoRegistor.ThemeAuthor = "Narwin";
            this.LblPhotoRegistor.ThemeName = "MetroLite";
            // 
            // PgbPhotoRegistor
            // 
            this.PgbPhotoRegistor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.PgbPhotoRegistor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.PgbPhotoRegistor.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.PgbPhotoRegistor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.PgbPhotoRegistor.DisabledProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.PgbPhotoRegistor.Location = new System.Drawing.Point(7, 24);
            this.PgbPhotoRegistor.Maximum = 100;
            this.PgbPhotoRegistor.Minimum = 0;
            this.PgbPhotoRegistor.Name = "PgbPhotoRegistor";
            this.PgbPhotoRegistor.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal;
            this.PgbPhotoRegistor.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.PgbPhotoRegistor.Size = new System.Drawing.Size(377, 37);
            this.PgbPhotoRegistor.Style = MetroSet_UI.Design.Style.Light;
            this.PgbPhotoRegistor.StyleManager = null;
            this.PgbPhotoRegistor.TabIndex = 0;
            this.PgbPhotoRegistor.Text = "metroSetProgressBar1";
            this.PgbPhotoRegistor.ThemeAuthor = "Narwin";
            this.PgbPhotoRegistor.ThemeName = "MetroLite";
            this.PgbPhotoRegistor.Value = 0;
            // 
            // BtnViewAll
            // 
            this.BtnViewAll.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnViewAll.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnViewAll.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnViewAll.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnViewAll.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnViewAll.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnViewAll.HoverTextColor = System.Drawing.Color.White;
            this.BtnViewAll.Location = new System.Drawing.Point(169, 645);
            this.BtnViewAll.Name = "BtnViewAll";
            this.BtnViewAll.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnViewAll.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnViewAll.NormalTextColor = System.Drawing.Color.White;
            this.BtnViewAll.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnViewAll.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnViewAll.PressTextColor = System.Drawing.Color.White;
            this.BtnViewAll.Size = new System.Drawing.Size(128, 40);
            this.BtnViewAll.Style = MetroSet_UI.Design.Style.Light;
            this.BtnViewAll.StyleManager = null;
            this.BtnViewAll.TabIndex = 1;
            this.BtnViewAll.Text = "VIEW ALL";
            this.BtnViewAll.ThemeAuthor = "Narwin";
            this.BtnViewAll.ThemeName = "MetroLite";
            this.BtnViewAll.Click += new System.EventHandler(this.BtnViewAll_Click);
            // 
            // BtnZoom
            // 
            this.BtnZoom.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnZoom.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnZoom.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnZoom.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnZoom.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnZoom.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnZoom.HoverTextColor = System.Drawing.Color.White;
            this.BtnZoom.Location = new System.Drawing.Point(304, 645);
            this.BtnZoom.Name = "BtnZoom";
            this.BtnZoom.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnZoom.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnZoom.NormalTextColor = System.Drawing.Color.White;
            this.BtnZoom.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnZoom.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnZoom.PressTextColor = System.Drawing.Color.White;
            this.BtnZoom.Size = new System.Drawing.Size(128, 40);
            this.BtnZoom.Style = MetroSet_UI.Design.Style.Light;
            this.BtnZoom.StyleManager = null;
            this.BtnZoom.TabIndex = 1;
            this.BtnZoom.Text = "ZOOM";
            this.BtnZoom.ThemeAuthor = "Narwin";
            this.BtnZoom.ThemeName = "MetroLite";
            this.BtnZoom.Click += new System.EventHandler(this.BtnZoom_Click);
            // 
            // ChtSensorValues
            // 
            chartArea1.Name = "ChartArea1";
            this.ChtSensorValues.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChtSensorValues.Legends.Add(legend1);
            this.ChtSensorValues.Location = new System.Drawing.Point(15, 358);
            this.ChtSensorValues.Name = "ChtSensorValues";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChtSensorValues.Series.Add(series1);
            this.ChtSensorValues.Size = new System.Drawing.Size(573, 281);
            this.ChtSensorValues.TabIndex = 6;
            this.ChtSensorValues.Text = "chart1";
            // 
            // RtbLog
            // 
            this.RtbLog.BackColor = System.Drawing.SystemColors.Control;
            this.RtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbLog.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RtbLog.Location = new System.Drawing.Point(15, 249);
            this.RtbLog.Name = "RtbLog";
            this.RtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RtbLog.Size = new System.Drawing.Size(390, 103);
            this.RtbLog.TabIndex = 7;
            this.RtbLog.Text = "";
            // 
            // MainForm
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 699);
            this.Controls.Add(this.RtbLog);
            this.Controls.Add(this.ChtSensorValues);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnZoom);
            this.Controls.Add(this.BtnViewAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtSensorCount);
            this.Controls.Add(this.LblConnectionTime);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(12, 70, 12, 11);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino PhotoRegister";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChtSensorValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuSubItemOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuSubItemSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuSubItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSimulation;
        private System.Windows.Forms.ToolStripMenuItem MenuSubItemStart;
        private System.Windows.Forms.ToolStripMenuItem MenuSubItemStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuSubItemInfo;
        private MetroSet_UI.Controls.MetroSetLabel LblConnectionTime;
        private MetroSet_UI.Controls.MetroSetTextBox TxtSensorCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroSet_UI.Controls.MetroSetComboBox CboSerialPort;
        private MetroSet_UI.Controls.MetroSetButton BtnPortValue;
        private MetroSet_UI.Controls.MetroSetButton BtnDisconnect;
        private MetroSet_UI.Controls.MetroSetButton BtnConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroSet_UI.Controls.MetroSetLabel LblPhotoRegistor;
        private MetroSet_UI.Controls.MetroSetProgressBar PgbPhotoRegistor;
        private MetroSet_UI.Controls.MetroSetButton BtnViewAll;
        private MetroSet_UI.Controls.MetroSetButton BtnZoom;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChtSensorValues;
        private System.Windows.Forms.RichTextBox RtbLog;
    }
}

