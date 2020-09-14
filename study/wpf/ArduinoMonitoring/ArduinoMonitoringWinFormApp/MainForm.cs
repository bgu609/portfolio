using ArduinoMonitoringWinFormApp.Base;
using MetroSet_UI.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ArduinoMonitoringWinFormApp
{
    public partial class MainForm : MetroSetForm
    {
        SerialPort serial;
        private short xCount = 200;
        private short maxPhotoVal = 1023;
        List<SensorData> photoDatas = new List<SensorData>();

        string strConnString = "Server=localhost;Port=3306;" +
            "Database=iot_sensordata;Uid=root;Pwd=mysql_p@ssw0rd";

        public bool IsSimulation { get; set; }

        Timer timer = new Timer();
        Random rand = new Random();

        public MainForm()
        {
            InitializeComponent();
            InitControls();
            InitChart();
        }

        private void InitChart()
        {
            ChtSensorValues.ChartAreas.Clear();
            ChtSensorValues.ChartAreas.Add("sensor");
            ChtSensorValues.ChartAreas["sensor"].AxisX.Minimum = 0;
            ChtSensorValues.ChartAreas["sensor"].AxisX.Maximum = xCount;
            ChtSensorValues.ChartAreas["sensor"].AxisX.Interval = xCount / 4;
            ChtSensorValues.ChartAreas["sensor"].AxisX.MajorGrid.LineColor = Color.White;
            ChtSensorValues.ChartAreas["sensor"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            ChtSensorValues.ChartAreas["sensor"].AxisX.ScaleView.Zoomable = true;
            ChtSensorValues.ChartAreas["sensor"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            ChtSensorValues.ChartAreas["sensor"].AxisX.ScrollBar.ButtonColor = Color.LightSteelBlue;
            ChtSensorValues.ChartAreas["sensor"].AxisY.Minimum = 0;
            ChtSensorValues.ChartAreas["sensor"].AxisY.Maximum = maxPhotoVal + 1;
            ChtSensorValues.ChartAreas["sensor"].AxisY.Interval = xCount;
            ChtSensorValues.ChartAreas["sensor"].AxisY.MajorGrid.LineColor = Color.White;
            ChtSensorValues.ChartAreas["sensor"].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtSensorValues.ChartAreas["sensor"].BackColor = Color.DarkBlue;
            ChtSensorValues.ChartAreas["sensor"].CursorX.AutoScroll = true;

            ChtSensorValues.Series.Clear();
            ChtSensorValues.Series.Add("PhotoRegistor");
            ChtSensorValues.Series["PhotoRegistor"].ChartType = SeriesChartType.Line;
            ChtSensorValues.Series["PhotoRegistor"].Color = Color.LightGreen;
            ChtSensorValues.Series["PhotoRegistor"].BorderWidth = 3;

            if (ChtSensorValues.Legends.Count > 0)
                ChtSensorValues.Legends.RemoveAt(0);


        }

        private void InitControls()
        {
            foreach (var item in SerialPort.GetPortNames())
            {
                CboSerialPort.Items.Add(item);
            }
            CboSerialPort.Text = "Select Port";

            PgbPhotoRegistor.Minimum = 0;
            PgbPhotoRegistor.Maximum = maxPhotoVal;

            BtnConnect.Enabled = BtnDisconnect.Enabled = false;

        }

        private void CboSerialPort_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var portName = CboSerialPort.SelectedItem.ToString();
            serial = new SerialPort(portName);
            serial.DataReceived += Serial_DataReceived;

            BtnConnect.Enabled = true;            
        }

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string sVal = serial.ReadLine();
            this.BeginInvoke(new Action(delegate { DisplayValue(sVal); }));
        }

        private void DisplayValue(string sVal)
        {
            try
            {
                ushort v = ushort.Parse(sVal);
                if (v < 0 || v > maxPhotoVal)
                    return;

                SensorData data = new SensorData(DateTime.Now, v);
                photoDatas.Add(data);
                InsertDataToDB(data);

                TxtSensorCount.Text = photoDatas.Count.ToString();
                PgbPhotoRegistor.Value = v;
                LblPhotoRegistor.Text = v.ToString();

                string item = $"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}\t{v}";

                RtbLog.AppendText($"{item}\n");
                RtbLog.ScrollToCaret();

                ChtSensorValues.Series[0].Points.Add(v);

                ChtSensorValues.ChartAreas[0].AxisX.Minimum = 0;
                ChtSensorValues.ChartAreas[0].AxisX.Maximum =
                    (photoDatas.Count >= xCount) ? photoDatas.Count : xCount;
               
                if (photoDatas.Count > xCount)
                    ChtSensorValues.ChartAreas[0].AxisX.ScaleView.Zoom(
                        photoDatas.Count - xCount, photoDatas.Count);
                else
                    ChtSensorValues.ChartAreas[0].AxisX.ScaleView.Zoom(0, xCount);

                if (IsSimulation == false) 
                    BtnPortValue.Text = $"{serial.PortName}\n{sVal}";
                else
                    BtnPortValue.Text = $"{sVal}";
            }
            catch (Exception ex)
            {
                RtbLog.AppendText($"Error : {ex.Message}\n");
                RtbLog.ScrollToCaret();
            }
        }

        private void InsertDataToDB(SensorData data)
        {
            string strQuery = "INSERT INTO sensordatatbl " +
                " (Date, Value) " +
                " VALUES " +
                " (@Date, @Value) ";

            using (MySqlConnection conn = new MySqlConnection(strConnString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlParameter paramDate = new MySqlParameter("@Date", MySqlDbType.DateTime)
                {
                    Value = data.Date
                };
                cmd.Parameters.Add(paramDate);
                MySqlParameter paramValue = new MySqlParameter("@Value", MySqlDbType.Int32)
                {
                    Value = data.Value
                };
                cmd.Parameters.Add(paramValue);
                cmd.ExecuteNonQuery();
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            serial.Open();
            LblConnectionTime.Text = $"연결시간 : {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}";
            BtnConnect.Enabled = false;
            BtnDisconnect.Enabled = true;
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            serial.Close();
            BtnConnect.Enabled = true;
            BtnDisconnect.Enabled = false;
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            ChtSensorValues.ChartAreas[0].AxisX.Minimum = 0;
            ChtSensorValues.ChartAreas[0].AxisX.Maximum = photoDatas.Count;
            ChtSensorValues.ChartAreas[0].AxisX.ScaleView.Zoom(0, photoDatas.Count);
            ChtSensorValues.ChartAreas[0].AxisX.Interval = photoDatas.Count / 4;
        }

        private void BtnZoom_Click(object sender, EventArgs e)
        {
            ChtSensorValues.ChartAreas[0].AxisX.Minimum = 0;
            ChtSensorValues.ChartAreas[0].AxisX.Maximum = photoDatas.Count;
            ChtSensorValues.ChartAreas[0].AxisX.ScaleView.Zoom(photoDatas.Count - xCount, photoDatas.Count);
            ChtSensorValues.ChartAreas[0].AxisX.Interval = photoDatas.Count / 4;
        }

        private void MenuSubItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuSubItemStart_Click(object sender, EventArgs e)
        {
            IsSimulation = true;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            // serial통신 끊기
            BtnDisconnect_Click(sender, e);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ushort value = (ushort)rand.Next(1, 1024);
            DisplayValue(value.ToString());
        }

        private void MenuSubItemStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            IsSimulation = false;

            // serial 통신 재시작
            BtnConnect_Click(sender, e);
        }

        private void MenuSubItemInfo_Click(object sender, EventArgs e)
        {
            ThisProgramForm form = new ThisProgramForm();
            form.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
