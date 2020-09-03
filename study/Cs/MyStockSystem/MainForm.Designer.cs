namespace MyStockSystem
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
            this.MtlInvestSimul = new MetroFramework.Controls.MetroTile();
            this.MtlStockAnalysis = new MetroFramework.Controls.MetroTile();
            this.MtlGalmatgilGuide = new MetroFramework.Controls.MetroTile();
            this.MtlSearchItem = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // MtlInvestSimul
            // 
            this.MtlInvestSimul.Location = new System.Drawing.Point(339, 265);
            this.MtlInvestSimul.Name = "MtlInvestSimul";
            this.MtlInvestSimul.Size = new System.Drawing.Size(241, 161);
            this.MtlInvestSimul.Style = MetroFramework.MetroColorStyle.Lime;
            this.MtlInvestSimul.TabIndex = 0;
            this.MtlInvestSimul.Text = "투자 시뮬레이션";
            this.MtlInvestSimul.TileImage = global::MyStockSystem.Properties.Resources.simulator2;
            this.MtlInvestSimul.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlInvestSimul.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MtlInvestSimul.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MtlInvestSimul.UseTileImage = true;
            // 
            // MtlStockAnalysis
            // 
            this.MtlStockAnalysis.Location = new System.Drawing.Point(339, 98);
            this.MtlStockAnalysis.Name = "MtlStockAnalysis";
            this.MtlStockAnalysis.Size = new System.Drawing.Size(141, 161);
            this.MtlStockAnalysis.Style = MetroFramework.MetroColorStyle.Orange;
            this.MtlStockAnalysis.TabIndex = 0;
            this.MtlStockAnalysis.Text = "주식정보분석";
            this.MtlStockAnalysis.TileImage = global::MyStockSystem.Properties.Resources.analysis2;
            this.MtlStockAnalysis.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlStockAnalysis.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MtlStockAnalysis.UseTileImage = true;
            // 
            // MtlGalmatgilGuide
            // 
            this.MtlGalmatgilGuide.Location = new System.Drawing.Point(486, 98);
            this.MtlGalmatgilGuide.Name = "MtlGalmatgilGuide";
            this.MtlGalmatgilGuide.Size = new System.Drawing.Size(261, 161);
            this.MtlGalmatgilGuide.Style = MetroFramework.MetroColorStyle.Purple;
            this.MtlGalmatgilGuide.TabIndex = 0;
            this.MtlGalmatgilGuide.Text = "갈맷길 정보";
            this.MtlGalmatgilGuide.TileImage = global::MyStockSystem.Properties.Resources.seagull2;
            this.MtlGalmatgilGuide.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlGalmatgilGuide.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MtlGalmatgilGuide.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MtlGalmatgilGuide.UseTileImage = true;
            this.MtlGalmatgilGuide.Click += new System.EventHandler(this.MtlGalmatgilGuide_Click);
            // 
            // MtlSearchItem
            // 
            this.MtlSearchItem.Location = new System.Drawing.Point(72, 98);
            this.MtlSearchItem.Name = "MtlSearchItem";
            this.MtlSearchItem.Size = new System.Drawing.Size(261, 161);
            this.MtlSearchItem.TabIndex = 0;
            this.MtlSearchItem.Text = "주식정보검색";
            this.MtlSearchItem.TileImage = global::MyStockSystem.Properties.Resources.marketing2;
            this.MtlSearchItem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlSearchItem.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MtlSearchItem.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MtlSearchItem.UseTileImage = true;
            this.MtlSearchItem.Click += new System.EventHandler(this.MtlSearchItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MtlInvestSimul);
            this.Controls.Add(this.MtlStockAnalysis);
            this.Controls.Add(this.MtlGalmatgilGuide);
            this.Controls.Add(this.MtlSearchItem);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "주식분석 시스템";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile MtlSearchItem;
        private MetroFramework.Controls.MetroTile MtlStockAnalysis;
        private MetroFramework.Controls.MetroTile MtlInvestSimul;
        private MetroFramework.Controls.MetroTile MtlGalmatgilGuide;
    }
}

