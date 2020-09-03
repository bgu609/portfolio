namespace BookRentalShopApp2020.subforms
{
    partial class BookMngForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
            this.TxtAuthor = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.TxtNames = new MetroFramework.Controls.MetroTextBox();
            this.TxtIsbn = new MetroFramework.Controls.MetroTextBox();
            this.TxtPrice = new MetroFramework.Controls.MetroTextBox();
            this.CboDivision = new MetroFramework.Controls.MetroComboBox();
            this.DtpReleaseDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(702, 497);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TxtIdx
            // 
            // 
            // 
            // 
            this.TxtIdx.CustomButton.Image = null;
            this.TxtIdx.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.TxtIdx.CustomButton.Name = "";
            this.TxtIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdx.CustomButton.TabIndex = 1;
            this.TxtIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdx.CustomButton.UseSelectable = true;
            this.TxtIdx.CustomButton.Visible = false;
            this.TxtIdx.Lines = new string[0];
            this.TxtIdx.Location = new System.Drawing.Point(849, 106);
            this.TxtIdx.MaxLength = 32767;
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.PasswordChar = '\0';
            this.TxtIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdx.SelectedText = "";
            this.TxtIdx.SelectionLength = 0;
            this.TxtIdx.SelectionStart = 0;
            this.TxtIdx.ShortcutsEnabled = true;
            this.TxtIdx.Size = new System.Drawing.Size(235, 23);
            this.TxtIdx.TabIndex = 0;
            this.TxtIdx.UseSelectable = true;
            this.TxtIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtAuthor
            // 
            // 
            // 
            // 
            this.TxtAuthor.CustomButton.Image = null;
            this.TxtAuthor.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.TxtAuthor.CustomButton.Name = "";
            this.TxtAuthor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAuthor.CustomButton.TabIndex = 1;
            this.TxtAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAuthor.CustomButton.UseSelectable = true;
            this.TxtAuthor.CustomButton.Visible = false;
            this.TxtAuthor.Lines = new string[0];
            this.TxtAuthor.Location = new System.Drawing.Point(849, 135);
            this.TxtAuthor.MaxLength = 32767;
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.PasswordChar = '\0';
            this.TxtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAuthor.SelectedText = "";
            this.TxtAuthor.SelectionLength = 0;
            this.TxtAuthor.SelectionStart = 0;
            this.TxtAuthor.ShortcutsEnabled = true;
            this.TxtAuthor.Size = new System.Drawing.Size(235, 23);
            this.TxtAuthor.TabIndex = 1;
            this.TxtAuthor.UseSelectable = true;
            this.TxtAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(996, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "저장";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(899, 353);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 39);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "신규";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(805, 353);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 39);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1088, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 39);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TxtNames
            // 
            // 
            // 
            // 
            this.TxtNames.CustomButton.Image = null;
            this.TxtNames.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.TxtNames.CustomButton.Name = "";
            this.TxtNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNames.CustomButton.TabIndex = 1;
            this.TxtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNames.CustomButton.UseSelectable = true;
            this.TxtNames.CustomButton.Visible = false;
            this.TxtNames.Lines = new string[0];
            this.TxtNames.Location = new System.Drawing.Point(849, 198);
            this.TxtNames.MaxLength = 32767;
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.PasswordChar = '\0';
            this.TxtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNames.SelectedText = "";
            this.TxtNames.SelectionLength = 0;
            this.TxtNames.SelectionStart = 0;
            this.TxtNames.ShortcutsEnabled = true;
            this.TxtNames.Size = new System.Drawing.Size(235, 23);
            this.TxtNames.TabIndex = 3;
            this.TxtNames.UseSelectable = true;
            this.TxtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNames.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtIsbn
            // 
            // 
            // 
            // 
            this.TxtIsbn.CustomButton.Image = null;
            this.TxtIsbn.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.TxtIsbn.CustomButton.Name = "";
            this.TxtIsbn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIsbn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIsbn.CustomButton.TabIndex = 1;
            this.TxtIsbn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIsbn.CustomButton.UseSelectable = true;
            this.TxtIsbn.CustomButton.Visible = false;
            this.TxtIsbn.Lines = new string[0];
            this.TxtIsbn.Location = new System.Drawing.Point(849, 260);
            this.TxtIsbn.MaxLength = 32767;
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.PasswordChar = '\0';
            this.TxtIsbn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIsbn.SelectedText = "";
            this.TxtIsbn.SelectionLength = 0;
            this.TxtIsbn.SelectionStart = 0;
            this.TxtIsbn.ShortcutsEnabled = true;
            this.TxtIsbn.Size = new System.Drawing.Size(235, 23);
            this.TxtIsbn.TabIndex = 5;
            this.TxtIsbn.UseSelectable = true;
            this.TxtIsbn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIsbn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPrice
            // 
            // 
            // 
            // 
            this.TxtPrice.CustomButton.Image = null;
            this.TxtPrice.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.TxtPrice.CustomButton.Name = "";
            this.TxtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPrice.CustomButton.TabIndex = 1;
            this.TxtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPrice.CustomButton.UseSelectable = true;
            this.TxtPrice.CustomButton.Visible = false;
            this.TxtPrice.Lines = new string[0];
            this.TxtPrice.Location = new System.Drawing.Point(849, 289);
            this.TxtPrice.MaxLength = 32767;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.PasswordChar = '\0';
            this.TxtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPrice.SelectedText = "";
            this.TxtPrice.SelectionLength = 0;
            this.TxtPrice.SelectionStart = 0;
            this.TxtPrice.ShortcutsEnabled = true;
            this.TxtPrice.Size = new System.Drawing.Size(235, 23);
            this.TxtPrice.TabIndex = 6;
            this.TxtPrice.UseSelectable = true;
            this.TxtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CboDivision
            // 
            this.CboDivision.FormattingEnabled = true;
            this.CboDivision.ItemHeight = 23;
            this.CboDivision.Location = new System.Drawing.Point(849, 165);
            this.CboDivision.Name = "CboDivision";
            this.CboDivision.Size = new System.Drawing.Size(235, 29);
            this.CboDivision.TabIndex = 2;
            this.CboDivision.UseSelectable = true;
            this.CboDivision.SelectedIndexChanged += new System.EventHandler(this.CboDivision_SelectedIndexChanged);
            // 
            // DtpReleaseDate
            // 
            this.DtpReleaseDate.Location = new System.Drawing.Point(849, 228);
            this.DtpReleaseDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpReleaseDate.Name = "DtpReleaseDate";
            this.DtpReleaseDate.Size = new System.Drawing.Size(235, 29);
            this.DtpReleaseDate.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(805, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "순번";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(805, 135);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "저자";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(800, 165);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "장르";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(787, 198);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "책 이름";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(791, 228);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "출간일";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(805, 260);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(32, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Isbn";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(800, 289);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(37, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "가격";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookMngForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 680);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.DtpReleaseDate);
            this.Controls.Add(this.CboDivision);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtIsbn);
            this.Controls.Add(this.TxtNames);
            this.Controls.Add(this.TxtAuthor);
            this.Controls.Add(this.TxtIdx);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookMngForm";
            this.Text = "도서 관리";
            this.Load += new System.EventHandler(this.tableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox TxtIdx;
        private MetroFramework.Controls.MetroTextBox TxtAuthor;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroTextBox TxtNames;
        private MetroFramework.Controls.MetroTextBox TxtIsbn;
        private MetroFramework.Controls.MetroTextBox TxtPrice;
        private MetroFramework.Controls.MetroComboBox CboDivision;
        private MetroFramework.Controls.MetroDateTime DtpReleaseDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}