using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MetroFramework.Forms;

namespace DisasterAlarm.Subitems
{
    public partial class MessageLog : MetroForm
    {
        public MessageLog()
        {
            InitializeComponent();
        }

        private void MessageLog_Load(object sender, EventArgs e)
        {

        }

        private void MessageLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            MainForm mainForm = new MainForm();
            mainForm.Location = this.Location;
            mainForm.ShowDialog();
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();

            /*
            str.Append("http://apis.data.go.kr/1741000/DisasterMsg2/getDisasterMsgList");
            str.Append("?ServiceKey=7B3kIELhmtfSHmJOGjcbKZtosaD%2BT8CXxxnrP5ooi4S7NEDQN%2FWEQ%2BD51oHgTR8u3FgfyBWqkquOchmAK296jw%3D%3D");
            str.Append("&pageNo=1");
            str.Append("&numOfRows=200");
            str.Append("&type=xml");
            str.Append("&flag=Y");*/
            str.Append("http://apis.data.go.kr/6260000/IncidentHistoryService/getIncidentHistoryList?ServiceKey=7B3kIELhmtfSHmJOGjcbKZtosaD%2BT8CXxxnrP5ooi4S7NEDQN%2FWEQ%2BD51oHgTR8u3FgfyBWqkquOchmAK296jw%3D%3D&numOfRows=50");

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");
            dataGridView1.Rows.Clear();

            try
            {
                foreach (XmlNode item in items)
                {
                    dataGridView1.Rows.Add(
                        item["INCIDENTDESC"].InnerText,
                        item["REGISTDATE"].InnerText,
                        item["X"].InnerText,
                        item["Y"].InnerText,
                        item["TITLE"].InnerText
                        );
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"에러발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
