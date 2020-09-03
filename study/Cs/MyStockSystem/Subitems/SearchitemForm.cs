using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MetroFramework.Forms;

namespace MyStockSystem.Subitems
{
    public partial class SearchitemForm : MetroForm
    {
        public SearchitemForm()
        {
            InitializeComponent();
        }

        private void SearchitemForm_Load(object sender, EventArgs e)
        {
            DgvSearchitem.Font = new Font(@"NanumGothic", 10, FontStyle.Regular);
        }

        private void MtlBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm mainForm = new MainForm();
            mainForm.Location = this.Location;
            mainForm.ShowDialog();
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();

            str.Append("http://api.seibro.or.kr/openapi/service/StockSvc/getStkIsinByNmN1");
            str.Append("?serviceKey=7B3kIELhmtfSHmJOGjcbKZtosaD%2BT8CXxxnrP5ooi4S7NEDQN%2FWEQ%2BD51oHgTR8u3FgfyBWqkquOchmAK296jw%3D%3D");
            str.Append($"&secnNm={txtSearchitem.Text}");
            str.Append("&numOfRows=200");
            str.Append("&pageNo=1");
            str.Append("&martTpcd=11");

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");
            DgvSearchitem.Rows.Clear();

            try
            {
                foreach (XmlNode item in items)
                {
                    DgvSearchitem.Rows.Add(
                        item["isin"].InnerText,
                        item["issuDt"] == null ? string.Empty : item["issuDt"].InnerText,
                        item["korSecnNm"].InnerText,
                        item["secnKacdNm"].InnerText,
                        item["shotnIsin"].InnerText
                        );
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"에러발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            DgvSearchitem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void txtSearchitem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                BtnSearch_Click(sender, new EventArgs());
            }
        }
    }
}
