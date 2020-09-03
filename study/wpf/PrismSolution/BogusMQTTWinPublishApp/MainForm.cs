using System;
using System.Text;
using System.Threading;
using Bogus;
using MetroFramework.Forms;
using Newtonsoft.Json;
using uPLibrary.Networking.M2Mqtt;

namespace BogusMQTTWinPublishApp
{
    public partial class MainForm : MetroForm
    {
        public static string MqttBrokerUrl { get; set; }

        public static MqttClient BrokerClient { get; set; }

        private static Thread MqttThread { get; set; }

        private static Faker<SensorInfo> SensorFaker { get; set; }

        private static string CurrValue { get; set; }

        public MainForm()
        {
            InitializeComponent();
            InitializeAll();
            TXTBroker.Text = MqttBrokerUrl;
        }

        private void BTNConnect_Click(object sender, EventArgs e)
        {
            ConnectMqttBroker();
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private static void InitializeAll()
        {
            MqttBrokerUrl = "localhost"; // or 127.0.0.1

            string[] Rooms = new[] { "Dining Room", "Living Room", "Bath Room", "Bed Room", "Guest Room" };

            SensorFaker = new Faker<SensorInfo>()
                .RuleFor(o => o.Dev_ID, f => f.PickRandom(Rooms))
                .RuleFor(o => o.Curr_Time, f => f.Date.Past(0).ToString("yyyy-MM-dd HH:mm:ss.ff"))
                .RuleFor(o => o.Temp, f => float.Parse(f.Random.Float(20.0f, 35.9f).ToString("0.00")))
                .RuleFor(o => o.Humid, f => float.Parse(f.Random.Float(40.0f, 63.9f).ToString("0.0")))
                .RuleFor(o => o.Press, f => float.Parse(f.Random.Float(899.0f, 1005.9f).ToString("0.0")));
        }

        private static void ConnectMqttBroker()
        {
            BrokerClient = new MqttClient(MqttBrokerUrl);
            BrokerClient.Connect("FakerDaemon");
        }

        private static void StartPublish()
        {
            MqttThread = new Thread(new ThreadStart(LoopPublish));
            //MqttThread = new Thread(() => LoopPublish());
            MqttThread.Start();
        }

        private static void LoopPublish()
        {
            while (true)
            {
                SensorInfo ThisValue = SensorFaker.Generate();
                CurrValue = JsonConvert.SerializeObject(ThisValue, Formatting.Indented);

                BrokerClient.Publish("home/device/data/", Encoding.Default.GetBytes(CurrValue));
                //Console.WriteLine($"Published : {CurrValue}");
                string publishtext = $"Published : {CurrValue}";

                Thread.Sleep(1000);
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                SensorInfo ThisValue = SensorFaker.Generate();
                CurrValue = JsonConvert.SerializeObject(ThisValue, Formatting.Indented);

                BrokerClient.Publish("home/device/data/", Encoding.Default.GetBytes(CurrValue));
                //Console.WriteLine($"Published : {CurrValue}");
                string publishtext = $"Published : {CurrValue}\n\n";
                RTBLog.AppendText(publishtext);
                RTBLog.ScrollToCaret();

                Thread.Sleep(1000);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            backgroundWorker1.CancelAsync();
            backgroundWorker1.Dispose();
        }
    }
}
