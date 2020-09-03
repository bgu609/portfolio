using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShopApp2020.subforms
{
    public partial class UserForm : Form
    {/*
        #region 멤버변수
        private readonly string strConnectionString = "Data Source=localhost; Port=3306; database=bookrentalshop; Uid=root; Password=epfls+358471;";
        readonly string strTblName = "memberTbl";
        #endregion

        #region 생성자
        public UserForm()
        {
            InitializeComponent();
        }
        #endregion

        #region 이벤트 핸들러
        private void RentalForm_Load(object sender, EventArgs e)
        {
            UpdateCboDivision();
            UpdateData();

            InitControls();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        #region 커스텀 메소드
        private void InitControls()
        {
            /*
            TxtIdx.Text = TxtAuthor.Text = TxtIsbn.Text = TxtNames.Text = TxtPrice.Text = string.Empty;
            CboDivision.SelectedIndex = 0;
            TxtIdx.ReadOnly = true;

            TxtIdx.Focus();

            DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
            DtpReleaseDate.Value = DateTime.Now;
            
        }

        private void UpdateCboDivision()
        {
            var keyValues = new Dictionary<string, string>();
            keyValues.Add("선택", "");
            keyValues.Add("A", "A");
            keyValues.Add("B", "B");
            keyValues.Add("C", "C");
            keyValues.Add("D", "D");

            metroComboBox1.DataSource = new BindingSource(keyValues, null);
            metroComboBox1.DisplayMember = "Key";
            metroComboBox1.ValueMember = "Value";
        }

        private void UpdateData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(strConnectionString)) //Commons.CONNSTR
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand
                    {
                        Connection = con
                    };

                    string strQuery = "SELECT Idx, " +
                                      "       memberIdx, " +
                                      "       bookIdx, " +
                                      "       rentalDate, " +
                                      "       returnDate " +
                                      "  FROM rentaltbl ";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, strTblName);

                    metroGrid1.DataSource = ds;
                    metroGrid1.DataMember = strTblName;
                }
                SetColumnHeaders();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"에러 발생 {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetColumnHeaders()
        {
            DataGridViewColumn column;

            column = metroGrid1.Columns[0];
            column.Width = 50;
            column.HeaderText = "대여번호";

            column = metroGrid1.Columns[1];
            column.Width = 100;
            column.HeaderText = "대여회원";

            column = metroGrid1.Columns[2];
            column.Width = 200;
            column.HeaderText = "대여책 제목";

            column = metroGrid1.Columns[3];
            column.Width = 200;
            column.HeaderText = "대여일";

            column = metroGrid1.Columns[4];
            column.Width = 200;
            column.HeaderText = "반납일";
        }
        #endregion*/
    }
}
