namespace DisasterAlarm.Subitems
{
    partial class MessageLog
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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.incident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axisx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axisy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(23, 99);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(550, 60);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.Text = "metroTextBox1";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(579, 99);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(104, 60);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "metroButton1";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(18, 174);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(851, 486);
            this.metroTabControl1.TabIndex = 2;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.dataGridView1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(843, 446);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "metroTabPage1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incident,
            this.date,
            this.axisx,
            this.axisy,
            this.title});
            this.dataGridView1.Location = new System.Drawing.Point(1, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(841, 446);
            this.dataGridView1.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(843, 446);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(843, 446);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "metroTabPage3";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(760, 99);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(104, 60);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "metroButton2";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // incident
            // 
            this.incident.HeaderText = "돌발상황";
            this.incident.Name = "incident";
            this.incident.Width = 400;
            // 
            // date
            // 
            this.date.HeaderText = "발생시간";
            this.date.Name = "date";
            // 
            // axisx
            // 
            this.axisx.HeaderText = "좌표(x)";
            this.axisx.Name = "axisx";
            this.axisx.Width = 60;
            // 
            // axisy
            // 
            this.axisy.HeaderText = "좌표(y)";
            this.axisy.Name = "axisy";
            this.axisy.Width = 60;
            // 
            // title
            // 
            this.title.HeaderText = "장소";
            this.title.Name = "title";
            this.title.Width = 200;
            // 
            // MessageLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 687);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Name = "MessageLog";
            this.Text = "MessageLog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessageLog_FormClosed);
            this.Load += new System.EventHandler(this.MessageLog_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn incident;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn axisx;
        private System.Windows.Forms.DataGridViewTextBoxColumn axisy;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
    }
}