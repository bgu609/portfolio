namespace MyStockSystem.Subitems
{
    partial class SearchitemForm
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
            this.MtlBack = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.BtnSearch = new MetroFramework.Controls.MetroButton();
            this.txtSearchitem = new MetroFramework.Controls.MetroTextBox();
            this.DgvSearchitem = new System.Windows.Forms.DataGridView();
            this.ISIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISSUDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KORSECNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SECNKACDNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHOTNISIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchitem)).BeginInit();
            this.SuspendLayout();
            // 
            // MtlBack
            // 
            this.MtlBack.Location = new System.Drawing.Point(1184, 657);
            this.MtlBack.Name = "MtlBack";
            this.MtlBack.Size = new System.Drawing.Size(70, 40);
            this.MtlBack.TabIndex = 1;
            this.MtlBack.TileImage = global::MyStockSystem.Properties.Resources.back2;
            this.MtlBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlBack.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MtlBack.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MtlBack.UseTileImage = true;
            this.MtlBack.Click += new System.EventHandler(this.MtlBack_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(26, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1228, 588);
            this.metroTabControl1.TabIndex = 2;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.splitContainer1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1220, 548);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "주식 기초정보 수집";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-4, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtSearchitem);
            this.splitContainer1.Panel1.Controls.Add(this.BtnSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvSearchitem);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1228, 440);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1220, 548);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "해당 정보 수집";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(1099, 24);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearchitem
            // 
            this.txtSearchitem.Location = new System.Drawing.Point(247, 24);
            this.txtSearchitem.Name = "txtSearchitem";
            this.txtSearchitem.Size = new System.Drawing.Size(661, 23);
            this.txtSearchitem.TabIndex = 1;
            this.txtSearchitem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchitem_KeyPress);
            // 
            // DgvSearchitem
            // 
            this.DgvSearchitem.AllowUserToAddRows = false;
            this.DgvSearchitem.AllowUserToDeleteRows = false;
            this.DgvSearchitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearchitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISIN,
            this.ISSUDT,
            this.KORSECNM,
            this.SECNKACDNM,
            this.SHOTNISIN});
            this.DgvSearchitem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSearchitem.Location = new System.Drawing.Point(0, 0);
            this.DgvSearchitem.Name = "DgvSearchitem";
            this.DgvSearchitem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DgvSearchitem.RowTemplate.Height = 23;
            this.DgvSearchitem.Size = new System.Drawing.Size(1228, 371);
            this.DgvSearchitem.TabIndex = 0;
            // 
            // ISIN
            // 
            this.ISIN.HeaderText = "표준 코드";
            this.ISIN.Name = "ISIN";
            // 
            // ISSUDT
            // 
            this.ISSUDT.HeaderText = "주식 발행일자";
            this.ISSUDT.Name = "ISSUDT";
            this.ISSUDT.Width = 110;
            // 
            // KORSECNM
            // 
            this.KORSECNM.HeaderText = "한글 종목명";
            this.KORSECNM.Name = "KORSECNM";
            // 
            // SECNKACDNM
            // 
            this.SECNKACDNM.HeaderText = "보통주 / 우선주";
            this.SECNKACDNM.Name = "SECNKACDNM";
            this.SECNKACDNM.Width = 150;
            // 
            // SHOTNISIN
            // 
            this.SHOTNISIN.HeaderText = "단축 코드";
            this.SHOTNISIN.Name = "SHOTNISIN";
            // 
            // SearchitemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.MtlBack);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MaximizeBox = false;
            this.Name = "SearchitemForm";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "주식정보검색";
            this.Load += new System.EventHandler(this.SearchitemForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile MtlBack;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroTextBox txtSearchitem;
        private MetroFramework.Controls.MetroButton BtnSearch;
        private System.Windows.Forms.DataGridView DgvSearchitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISSUDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KORSECNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SECNKACDNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHOTNISIN;
    }
}