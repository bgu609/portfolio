namespace PublicBidApp
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
            this.BidNotice = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // BidNotice
            // 
            this.BidNotice.ActiveControl = null;
            this.BidNotice.Location = new System.Drawing.Point(52, 91);
            this.BidNotice.Name = "BidNotice";
            this.BidNotice.Size = new System.Drawing.Size(110, 111);
            this.BidNotice.TabIndex = 0;
            this.BidNotice.Text = "입찰 공고";
            this.BidNotice.UseSelectable = true;
            this.BidNotice.Click += new System.EventHandler(this.BidNotice_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BidNotice);
            this.Name = "MainForm";
            this.Text = "공공 입찰";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile BidNotice;
    }
}

