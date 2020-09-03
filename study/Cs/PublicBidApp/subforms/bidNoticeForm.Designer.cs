namespace PublicBidApp.subforms
{
    partial class bidNoticeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bidNoticeGrid = new MetroFramework.Controls.MetroGrid();
            this.columnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidNtceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidNtceOrd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidNtceNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidNtceDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoticeResetBtn = new MetroFramework.Controls.MetroButton();
            this.bidNoticesplitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtRowNum = new MetroFramework.Controls.MetroTextBox();
            this.NoticeProgressBar = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.bidNoticeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidNoticesplitContainer)).BeginInit();
            this.bidNoticesplitContainer.Panel1.SuspendLayout();
            this.bidNoticesplitContainer.Panel2.SuspendLayout();
            this.bidNoticesplitContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bidNoticeGrid
            // 
            this.bidNoticeGrid.AllowUserToAddRows = false;
            this.bidNoticeGrid.AllowUserToDeleteRows = false;
            this.bidNoticeGrid.AllowUserToResizeRows = false;
            this.bidNoticeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bidNoticeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bidNoticeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bidNoticeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bidNoticeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bidNoticeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bidNoticeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNo,
            this.bidNtceNo,
            this.bidNtceOrd,
            this.bidNtceNm,
            this.bidNtceDt,
            this.hrul});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bidNoticeGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.bidNoticeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bidNoticeGrid.EnableHeadersVisualStyles = false;
            this.bidNoticeGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bidNoticeGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bidNoticeGrid.Location = new System.Drawing.Point(0, 0);
            this.bidNoticeGrid.MultiSelect = false;
            this.bidNoticeGrid.Name = "bidNoticeGrid";
            this.bidNoticeGrid.ReadOnly = true;
            this.bidNoticeGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bidNoticeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bidNoticeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bidNoticeGrid.RowTemplate.Height = 23;
            this.bidNoticeGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bidNoticeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bidNoticeGrid.Size = new System.Drawing.Size(787, 566);
            this.bidNoticeGrid.TabIndex = 2;
            this.bidNoticeGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bidNoticeGrid_CellClick);
            // 
            // columnNo
            // 
            this.columnNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnNo.HeaderText = "";
            this.columnNo.Name = "columnNo";
            this.columnNo.ReadOnly = true;
            this.columnNo.Width = 17;
            // 
            // bidNtceNo
            // 
            this.bidNtceNo.HeaderText = "입찰공고 번호";
            this.bidNtceNo.Name = "bidNtceNo";
            this.bidNtceNo.ReadOnly = true;
            // 
            // bidNtceOrd
            // 
            this.bidNtceOrd.HeaderText = "차수";
            this.bidNtceOrd.Name = "bidNtceOrd";
            this.bidNtceOrd.ReadOnly = true;
            // 
            // bidNtceNm
            // 
            this.bidNtceNm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bidNtceNm.HeaderText = "입찰공고명";
            this.bidNtceNm.Name = "bidNtceNm";
            this.bidNtceNm.ReadOnly = true;
            // 
            // bidNtceDt
            // 
            this.bidNtceDt.HeaderText = "공고 일시";
            this.bidNtceDt.Name = "bidNtceDt";
            this.bidNtceDt.ReadOnly = true;
            // 
            // hrul
            // 
            this.hrul.HeaderText = "hrul";
            this.hrul.Name = "hrul";
            this.hrul.ReadOnly = true;
            this.hrul.Visible = false;
            // 
            // NoticeResetBtn
            // 
            this.NoticeResetBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.NoticeResetBtn.Location = new System.Drawing.Point(3, 3);
            this.NoticeResetBtn.Name = "NoticeResetBtn";
            this.NoticeResetBtn.Size = new System.Drawing.Size(90, 45);
            this.NoticeResetBtn.TabIndex = 1;
            this.NoticeResetBtn.Text = "목록 갱신";
            this.NoticeResetBtn.UseSelectable = true;
            this.NoticeResetBtn.Click += new System.EventHandler(this.NoticeResetBtn_Click);
            // 
            // bidNoticesplitContainer
            // 
            this.bidNoticesplitContainer.Location = new System.Drawing.Point(14, 63);
            this.bidNoticesplitContainer.Name = "bidNoticesplitContainer";
            // 
            // bidNoticesplitContainer.Panel1
            // 
            this.bidNoticesplitContainer.Panel1.Controls.Add(this.bidNoticeGrid);
            // 
            // bidNoticesplitContainer.Panel2
            // 
            this.bidNoticesplitContainer.Panel2.Controls.Add(this.groupBox1);
            this.bidNoticesplitContainer.Panel2.Controls.Add(this.metroLabel1);
            this.bidNoticesplitContainer.Panel2.Controls.Add(this.txtRowNum);
            this.bidNoticesplitContainer.Panel2.Controls.Add(this.NoticeResetBtn);
            this.bidNoticesplitContainer.Size = new System.Drawing.Size(1186, 566);
            this.bidNoticesplitContainer.SplitterDistance = 787;
            this.bidNoticesplitContainer.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(8, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 454);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상세";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(17, 39);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 12);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "바로가기 : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "검색 범위";
            // 
            // txtRowNum
            // 
            // 
            // 
            // 
            this.txtRowNum.CustomButton.Image = null;
            this.txtRowNum.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.txtRowNum.CustomButton.Name = "";
            this.txtRowNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRowNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRowNum.CustomButton.TabIndex = 1;
            this.txtRowNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRowNum.CustomButton.UseSelectable = true;
            this.txtRowNum.CustomButton.Visible = false;
            this.txtRowNum.Lines = new string[0];
            this.txtRowNum.Location = new System.Drawing.Point(3, 79);
            this.txtRowNum.MaxLength = 32767;
            this.txtRowNum.Name = "txtRowNum";
            this.txtRowNum.PasswordChar = '\0';
            this.txtRowNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRowNum.SelectedText = "";
            this.txtRowNum.SelectionLength = 0;
            this.txtRowNum.SelectionStart = 0;
            this.txtRowNum.ShortcutsEnabled = true;
            this.txtRowNum.Size = new System.Drawing.Size(88, 23);
            this.txtRowNum.TabIndex = 0;
            this.txtRowNum.UseSelectable = true;
            this.txtRowNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRowNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRowNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRowNum_KeyPress);
            // 
            // NoticeProgressBar
            // 
            this.NoticeProgressBar.Location = new System.Drawing.Point(17, 636);
            this.NoticeProgressBar.Name = "NoticeProgressBar";
            this.NoticeProgressBar.Size = new System.Drawing.Size(781, 23);
            this.NoticeProgressBar.Step = 1;
            this.NoticeProgressBar.TabIndex = 3;
            // 
            // bidNoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 682);
            this.Controls.Add(this.NoticeProgressBar);
            this.Controls.Add(this.bidNoticesplitContainer);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "bidNoticeForm";
            this.Text = "입찰 공고";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.bidNoticeForm_FormClosed);
            this.Load += new System.EventHandler(this.bidNoticeForm_Load);
            this.Shown += new System.EventHandler(this.bidNoticeForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bidNoticeGrid)).EndInit();
            this.bidNoticesplitContainer.Panel1.ResumeLayout(false);
            this.bidNoticesplitContainer.Panel2.ResumeLayout(false);
            this.bidNoticesplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bidNoticesplitContainer)).EndInit();
            this.bidNoticesplitContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid bidNoticeGrid;
        private MetroFramework.Controls.MetroButton NoticeResetBtn;
        private System.Windows.Forms.SplitContainer bidNoticesplitContainer;
        private MetroFramework.Controls.MetroTextBox txtRowNum;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar NoticeProgressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidNtceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidNtceOrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidNtceNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidNtceDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}