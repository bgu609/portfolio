namespace BogusMQTTWinPublishApp
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TXTBroker = new MetroFramework.Controls.MetroTextBox();
            this.BTNConnect = new MetroFramework.Controls.MetroButton();
            this.RTBLog = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(23, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "MQTT Broker IP";
            // 
            // TXTBroker
            // 
            // 
            // 
            // 
            this.TXTBroker.CustomButton.Image = null;
            this.TXTBroker.CustomButton.Location = new System.Drawing.Point(564, 1);
            this.TXTBroker.CustomButton.Name = "";
            this.TXTBroker.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTBroker.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTBroker.CustomButton.TabIndex = 1;
            this.TXTBroker.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTBroker.CustomButton.UseSelectable = true;
            this.TXTBroker.CustomButton.Visible = false;
            this.TXTBroker.Lines = new string[0];
            this.TXTBroker.Location = new System.Drawing.Point(110, 91);
            this.TXTBroker.MaxLength = 32767;
            this.TXTBroker.Name = "TXTBroker";
            this.TXTBroker.PasswordChar = '\0';
            this.TXTBroker.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTBroker.SelectedText = "";
            this.TXTBroker.SelectionLength = 0;
            this.TXTBroker.SelectionStart = 0;
            this.TXTBroker.ShortcutsEnabled = true;
            this.TXTBroker.Size = new System.Drawing.Size(586, 23);
            this.TXTBroker.TabIndex = 1;
            this.TXTBroker.UseSelectable = true;
            this.TXTBroker.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTBroker.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BTNConnect
            // 
            this.BTNConnect.Location = new System.Drawing.Point(702, 91);
            this.BTNConnect.Name = "BTNConnect";
            this.BTNConnect.Size = new System.Drawing.Size(75, 23);
            this.BTNConnect.TabIndex = 2;
            this.BTNConnect.Text = "Connect";
            this.BTNConnect.UseSelectable = true;
            this.BTNConnect.Click += new System.EventHandler(this.BTNConnect_Click);
            // 
            // RTBLog
            // 
            this.RTBLog.Location = new System.Drawing.Point(23, 120);
            this.RTBLog.Name = "RTBLog";
            this.RTBLog.Size = new System.Drawing.Size(754, 307);
            this.RTBLog.TabIndex = 3;
            this.RTBLog.Text = "";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RTBLog);
            this.Controls.Add(this.BTNConnect);
            this.Controls.Add(this.TXTBroker);
            this.Controls.Add(this.metroLabel1);
            this.Name = "MainForm";
            this.Text = "MQTT Fake Publisher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TXTBroker;
        private MetroFramework.Controls.MetroButton BTNConnect;
        private System.Windows.Forms.RichTextBox RTBLog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

