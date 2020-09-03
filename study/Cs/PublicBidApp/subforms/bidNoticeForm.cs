using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MetroFramework;
using MetroFramework.Forms;

namespace PublicBidApp.subforms
{
    public partial class bidNoticeForm : MetroForm
    {
        int idxcall = 0;
        int rows = 999;
        public bidNoticeForm()
        {
            InitializeComponent();
        }

        private void bidNoticeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void bidNoticeListLoad()
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();

            str.Append("http://apis.data.go.kr/1230000/BidPublicInfoService/getBidPblancListInfoCnstwk?inqryDiv=1");
            str.Append("&ServiceKey=7B3kIELhmtfSHmJOGjcbKZtosaD%2BT8CXxxnrP5ooi4S7NEDQN%2FWEQ%2BD51oHgTR8u3FgfyBWqkquOchmAK296jw%3D%3D");
            str.Append("&inqryBgnDt=202001010000");
            str.Append($"&numOfRows={txtRowNum.Text}");

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            //XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");
            bidNoticeGrid.Rows.Clear();

            NoticeProgressBar.Minimum = 0;
            try
            {
                NoticeProgressBar.Maximum = int.Parse(txtRowNum.Text);
            }
            catch (FormatException)
            {
                MetroMessageBox.Show(this, "숫자로 입력하세요", "갱신 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRowNum.Clear();
                txtRowNum.Focus();
            }
            
            try
            {
                foreach (XmlNode item in items)
                {
                    bidNoticeGrid.Rows.Add(
                        ++idxcall,
                        item["bidNtceNo"].InnerText,
                        item["bidNtceOrd"].InnerText,
                        item["bidNtceNm"].InnerText,
                        item["bidNtceDt"].InnerText,
                        item["bidNtceDtlUrl"].InnerText
                        );
                    NoticeProgressBar.Value = idxcall;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"에러발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                idxcall = 0;
                NoticeProgressBar.Value = 0;
            }

            bidNoticeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void bidNoticeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            MainForm mainForm = new MainForm();
            mainForm.Location = this.Location;
            mainForm.ShowDialog();
            this.Close();
        }

        private void NoticeResetBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(bidNoticeListLoad));
            thread.Start();
        }

        private void txtRowNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                NoticeResetBtn_Click(sender, new EventArgs());
            }
        }

        private void bidNoticeForm_Shown(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(bidNoticeListLoad));
            thread.Start();
            txtRowNum.Text = rows.ToString();
        }

        private void bidNoticeGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linkLabel1.Text = bidNoticeGrid.SelectedCells[3].Value.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(bidNoticeGrid.SelectedCells[5].Value.ToString());
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "에러", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
