namespace BackgroundWorker
{
    partial class Form1
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
            this.LBLResult = new System.Windows.Forms.Label();
            this.BTNStart = new System.Windows.Forms.Button();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LBLResult
            // 
            this.LBLResult.AutoSize = true;
            this.LBLResult.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLResult.Location = new System.Drawing.Point(12, 9);
            this.LBLResult.Name = "LBLResult";
            this.LBLResult.Size = new System.Drawing.Size(197, 37);
            this.LBLResult.TabIndex = 0;
            this.LBLResult.Text = "Result Content";
            // 
            // BTNStart
            // 
            this.BTNStart.Location = new System.Drawing.Point(71, 127);
            this.BTNStart.Name = "BTNStart";
            this.BTNStart.Size = new System.Drawing.Size(89, 40);
            this.BTNStart.TabIndex = 1;
            this.BTNStart.Text = "Start";
            this.BTNStart.UseVisualStyleBackColor = true;
            this.BTNStart.Click += new System.EventHandler(this.BTNStart_Click);
            // 
            // BTNCancel
            // 
            this.BTNCancel.Location = new System.Drawing.Point(166, 127);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(89, 40);
            this.BTNCancel.TabIndex = 2;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.UseVisualStyleBackColor = true;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 73);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(311, 30);
            this.progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 225);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.BTNStart);
            this.Controls.Add(this.LBLResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLResult;
        private System.Windows.Forms.Button BTNStart;
        private System.Windows.Forms.Button BTNCancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

