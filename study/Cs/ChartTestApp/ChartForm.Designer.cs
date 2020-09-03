namespace ChartTestApp
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnDBbind = new MetroFramework.Controls.MetroButton();
            this.btnMultichart = new MetroFramework.Controls.MetroButton();
            this.btnDataBind = new MetroFramework.Controls.MetroButton();
            this.btnXYvalues = new MetroFramework.Controls.MetroButton();
            this.btnYvalues = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 63);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "score";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(754, 594);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnDBbind);
            this.metroPanel1.Controls.Add(this.btnMultichart);
            this.metroPanel1.Controls.Add(this.btnDataBind);
            this.metroPanel1.Controls.Add(this.btnXYvalues);
            this.metroPanel1.Controls.Add(this.btnYvalues);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(784, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(273, 594);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnDBbind
            // 
            this.btnDBbind.Location = new System.Drawing.Point(64, 329);
            this.btnDBbind.Name = "btnDBbind";
            this.btnDBbind.Size = new System.Drawing.Size(149, 63);
            this.btnDBbind.TabIndex = 2;
            this.btnDBbind.Text = "DB bind";
            this.btnDBbind.UseSelectable = true;
            this.btnDBbind.Click += new System.EventHandler(this.btnDBbind_Click);
            // 
            // btnMultichart
            // 
            this.btnMultichart.Location = new System.Drawing.Point(64, 241);
            this.btnMultichart.Name = "btnMultichart";
            this.btnMultichart.Size = new System.Drawing.Size(149, 63);
            this.btnMultichart.TabIndex = 2;
            this.btnMultichart.Text = "Multi Chart";
            this.btnMultichart.UseSelectable = true;
            this.btnMultichart.Click += new System.EventHandler(this.btnMultichart_Click);
            // 
            // btnDataBind
            // 
            this.btnDataBind.Location = new System.Drawing.Point(64, 172);
            this.btnDataBind.Name = "btnDataBind";
            this.btnDataBind.Size = new System.Drawing.Size(149, 63);
            this.btnDataBind.TabIndex = 2;
            this.btnDataBind.Text = "Data Bind";
            this.btnDataBind.UseSelectable = true;
            this.btnDataBind.Click += new System.EventHandler(this.btnDataBind_Click);
            // 
            // btnXYvalues
            // 
            this.btnXYvalues.Location = new System.Drawing.Point(64, 72);
            this.btnXYvalues.Name = "btnXYvalues";
            this.btnXYvalues.Size = new System.Drawing.Size(149, 63);
            this.btnXYvalues.TabIndex = 2;
            this.btnXYvalues.Text = "XY values";
            this.btnXYvalues.UseSelectable = true;
            this.btnXYvalues.Click += new System.EventHandler(this.btnXYvalues_Click);
            // 
            // btnYvalues
            // 
            this.btnYvalues.Location = new System.Drawing.Point(64, 3);
            this.btnYvalues.Name = "btnYvalues";
            this.btnYvalues.Size = new System.Drawing.Size(149, 63);
            this.btnYvalues.TabIndex = 2;
            this.btnYvalues.Text = "Only Y values";
            this.btnYvalues.UseSelectable = true;
            this.btnYvalues.Click += new System.EventHandler(this.btnYvalues_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 680);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChartForm";
            this.Resizable = false;
            this.Text = "ChartTestApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnYvalues;
        private MetroFramework.Controls.MetroButton btnXYvalues;
        private MetroFramework.Controls.MetroButton btnDataBind;
        private MetroFramework.Controls.MetroButton btnMultichart;
        private MetroFramework.Controls.MetroButton btnDBbind;
    }
}

