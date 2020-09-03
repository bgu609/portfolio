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
using Newtonsoft.Json.Linq;

namespace MyStockSystem.Subitems
{
    public partial class GalmatgilForm : MetroForm
    {
        public GalmatgilForm()
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

            str.Append("http://apis.data.go.kr/6260000/BusanGalmaetGilService/getGalmaetGilInfo");
            str.Append("?ServiceKey=7B3kIELhmtfSHmJOGjcbKZtosaD%2BT8CXxxnrP5ooi4S7NEDQN%2FWEQ%2BD51oHgTR8u3FgfyBWqkquOchmAK296jw%3D%3D");
            //str.Append("&pageNo=1");
            //str.Append("&numOfRaws=10");
            str.Append("&resultType=json");

            string json = wc.DownloadString(str.ToString());
            JObject obj = JObject.Parse(json);

            JToken Items = JArray.Parse(obj.SelectToken("getGalmaetGilInfo.item").ToString());

            DgvSearchitem.Rows.Clear();

            try
            {
                foreach (var item in Items)
                {
                    DgvSearchitem.Rows.Add(
                        $"{item.SelectToken("kosNm")}",
                        $"{item.SelectToken("kosType")}",
                        $"{item.SelectToken("kosTxt")}",
                        $"{item.SelectToken("img")}",
                        $"{item.SelectToken("txt1")}",
                        $"{item.SelectToken("title")}",
                        $"{item.SelectToken("txt2")}"
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

        private void DgvSearchitem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellvalue = DgvSearchitem.Rows[e.RowIndex].Cells[3].Value.ToString();
            //MessageBox.Show(cellvalue);
            downloadForm form = new downloadForm();
            form.ParentUrl = cellvalue;
            form.ShowDialog();
        }
    }
}
