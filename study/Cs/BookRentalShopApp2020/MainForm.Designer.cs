namespace BookRentalShopApp2020
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuMng = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnuitem_code = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemBooksMng = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemRentalMng = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemUserMng = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnuitem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMng});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuMng
            // 
            this.MnuMng.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnuitem_code,
            this.MnuItemBooksMng,
            this.MnuItemRentalMng,
            this.MnuItemUserMng,
            this.toolStripMenuItem1,
            this.Mnuitem_exit});
            this.MnuMng.Name = "MnuMng";
            this.MnuMng.Size = new System.Drawing.Size(66, 20);
            this.MnuMng.Text = "관리 (&M)";
            // 
            // Mnuitem_code
            // 
            this.Mnuitem_code.Name = "Mnuitem_code";
            this.Mnuitem_code.Size = new System.Drawing.Size(172, 22);
            this.Mnuitem_code.Text = "코드관리 (&C)";
            this.Mnuitem_code.Click += new System.EventHandler(this.Mnuitem_code_Click);
            // 
            // MnuItemBooksMng
            // 
            this.MnuItemBooksMng.Name = "MnuItemBooksMng";
            this.MnuItemBooksMng.Size = new System.Drawing.Size(172, 22);
            this.MnuItemBooksMng.Text = "도서관리";
            this.MnuItemBooksMng.Click += new System.EventHandler(this.MnuItemBooksMng_Click);
            // 
            // MnuItemRentalMng
            // 
            this.MnuItemRentalMng.Name = "MnuItemRentalMng";
            this.MnuItemRentalMng.Size = new System.Drawing.Size(172, 22);
            this.MnuItemRentalMng.Text = "대여관리";
            this.MnuItemRentalMng.Click += new System.EventHandler(this.MnuItemRentalMng_Click);
            // 
            // MnuItemUserMng
            // 
            this.MnuItemUserMng.Name = "MnuItemUserMng";
            this.MnuItemUserMng.Size = new System.Drawing.Size(172, 22);
            this.MnuItemUserMng.Text = "사용자 관리";
            this.MnuItemUserMng.Click += new System.EventHandler(this.MnuItemUserMng_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
            // 
            // Mnuitem_exit
            // 
            this.Mnuitem_exit.Name = "Mnuitem_exit";
            this.Mnuitem_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Mnuitem_exit.Size = new System.Drawing.Size(172, 22);
            this.Mnuitem_exit.Text = "끝내기 (&X)";
            this.Mnuitem_exit.Click += new System.EventHandler(this.Mnuitem_exit_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(303, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(278, 24);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 680);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.Text = "Book Rental Shop v0.8";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuMng;
        private System.Windows.Forms.ToolStripMenuItem Mnuitem_code;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Mnuitem_exit;
        private System.Windows.Forms.ToolStripMenuItem MnuItemBooksMng;
        private System.Windows.Forms.ToolStripMenuItem MnuItemRentalMng;
        private System.Windows.Forms.ToolStripMenuItem MnuItemUserMng;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

