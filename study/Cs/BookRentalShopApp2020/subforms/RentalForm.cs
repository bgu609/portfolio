using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace BookRentalShopApp2020.subforms
{
    public partial class RentalForm : MetroForm
    {
        #region 멤버변수
        //private readonly string strConnectionString = "Data Source=localhost; Port=3306; database=bookrentalshop; Uid=root; Password=epfls+358471;";
        readonly string strTblName = "rentalTbl";

        public enum BaseMode
        {
            None,
            INSERT,
            UPDATE,
            SELECT,
            DELETE
        }

        BaseMode myMode = BaseMode.None;
        #endregion

        #region 생성자
        public RentalForm()
        {
            InitializeComponent();
        }
        #endregion

        #region 이벤트 핸들러
        private void RentalForm_Load(object sender, EventArgs e)
        {
            UpdateCboMember();
            UpdateCboBook();
            UpdateData();

            InitControls();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = metroGrid1.Rows[e.RowIndex];

                metroTextBox1.Text = data.Cells[0].Value.ToString();

                metroComboBox1.SelectedIndex = metroComboBox1.FindString(data.Cells[1].Value.ToString());
                metroComboBox2.SelectedValue = data.Cells[6].Value.ToString();

                metroDateTime1.Value = DateTime.Parse(data.Cells[4].Value.ToString());

                metroDateTime2.CustomFormat = "yyyy-MM-dd";
                metroDateTime2.Format = DateTimePickerFormat.Custom;
                if (string.IsNullOrEmpty(data.Cells[5].Value.ToString()) != true)
                {
                    metroDateTime2.Value = DateTime.Parse(data.Cells[5].Value.ToString());
                }
                else
                {
                    metroDateTime2.CustomFormat = " ";
                    metroDateTime2.Format = DateTimePickerFormat.Custom;
                }

                metroTextBox1.ReadOnly = true;
            }
        }

        private void metroDateTime2_ValueChanged(object sender, EventArgs e)
        {
            metroDateTime2.CustomFormat = "yyyy-MM-dd";
            metroDateTime2.Format = DateTimePickerFormat.Custom;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            myMode = BaseMode.INSERT;
            InitControls();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Savedata();
            myMode = BaseMode.UPDATE;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            myMode = BaseMode.UPDATE;
            InitControls();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet1 = workbook.CreateSheet("sheet1");
            sheet1.CreateRow(0).CreateCell(0).SetCellValue("Rental Book Data");
            //int x = 1;

            DataSet ds = metroGrid1.DataSource as DataSet;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                IRow row = sheet1.CreateRow(i);
                for (int j = 0; j < ds.Tables[0].Rows[0].ItemArray.Length; j++)
                {
                    if(j>5)
                    {
                        break;
                    }
                    else if(j==4||j==5)
                    {
                        var value = string.IsNullOrEmpty(ds.Tables[0].Rows[i].ItemArray[j].ToString())? "":ds.Tables[0].Rows[i].ItemArray[j].ToString().Substring(0,10);
                        row.CreateCell(j-2).SetCellValue(value);
                    }
                    else if(j==0||j==3)
                    {

                    }
                    else
                    {
                        row.CreateCell(j-1).SetCellValue(ds.Tables[0].Rows[i].ItemArray[j].ToString());
                    }
                }
            }

            FileStream file = File.Create(Environment.CurrentDirectory + $"\\export.xlsx");
            workbook.Write(file);
            file.Close();

            MessageBox.Show("Export Complete");
        }
        #endregion

        #region 커스텀 메소드
        private void InitControls()
        {
            metroTextBox1.Text = string.Empty;
            metroTextBox1.Focus();
            metroTextBox1.ReadOnly = true;

            metroComboBox1.SelectedIndex = metroComboBox2.SelectedIndex = 0;

            metroDateTime1.CustomFormat = "yyyy-MM-dd";
            metroDateTime2.CustomFormat = " ";
            metroDateTime1.Format = DateTimePickerFormat.Custom;
            metroDateTime2.Format = DateTimePickerFormat.Custom;
            metroDateTime1.Value = DateTime.Now;
        }

        private void UpdateCboMember()
        {
            using (MySqlConnection con = new MySqlConnection(Common.CONSTR)) //strConnectionString
            {
                con.Open();

                string strQuery = "SELECT Idx, Names FROM memberTbl ";

                MySqlCommand cmd = new MySqlCommand(strQuery, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, string> temp = new Dictionary<string, string>();
                temp.Add("0", "선택");
                while (reader.Read())
                {
                    temp.Add(reader[0].ToString(), reader[1].ToString());
                }

                metroComboBox1.DataSource = new BindingSource(temp, null);
                metroComboBox1.DisplayMember = "Value";
                metroComboBox1.ValueMember = "Key";
                metroComboBox1.SelectedIndex = 0;
            }
        }

        private void UpdateCboBook()
        {
            using (MySqlConnection con = new MySqlConnection(Common.CONSTR))
            {
                con.Open();

                string strQuery = "SELECT Idx, b.Names, (SELECT d.Names FROM divTbl AS d WHERE Division = b.Division) AS Division FROM booksTbl AS b ";

                MySqlCommand cmd = new MySqlCommand(strQuery, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, string> temp = new Dictionary<string, string>();
                temp.Add("0", "선택");
                while (reader.Read())
                {
                    temp.Add($"{reader[0]}", $"[{reader[2]}] {reader[1]}");
                }

                metroComboBox2.DataSource = new BindingSource(temp, null);
                metroComboBox2.DisplayMember = "Value";
                metroComboBox2.ValueMember = "Key";
                metroComboBox2.SelectedIndex = 0;
            }
        }

        private void UpdateData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Common.CONSTR))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand
                    {
                        Connection = con
                    };

                    string strQuery = "SELECT r.idx AS '대여번호', " +
                                      "       m.Names AS '대여회원', " +
                                      "       b.Names AS '대여책제목', " +
                                      "       b.ISBN, " +
                                      "       r.rentalDate AS '대여일', " +
                                      "       r.returnDate AS '반납일', " +
                                      "       r.bookIdx " +
                                      "  FROM rentaltbl AS r " +
                                      " INNER JOIN membertbl AS m " +
                                      "    ON r.memberIdx = m.Idx " +
                                      " INNER JOIN bookstbl AS b " +
                                      "    ON r.bookIdx = b.Idx ";

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
            column.Width = 100;
            column.HeaderText = "ISBN";
            column.Visible = false;
            
            column = metroGrid1.Columns[4];
            column.Width = 100;
            column.HeaderText = "대여일";

            column = metroGrid1.Columns[5];
            column.Width = 100;
            column.HeaderText = "반납일";

            column = metroGrid1.Columns[6];
            column.Width = 100;
            column.HeaderText = "bookidx";
            column.Visible = false;
        }

        private void Savedata()
        {
            if (string.IsNullOrEmpty(metroTextBox1.Text) || metroComboBox1.SelectedIndex < 1 || metroComboBox2.SelectedIndex < 1 || metroDateTime1.Value==null || metroDateTime2.Value == null)
            {
                MetroMessageBox.Show(this, "빈값은 넣을 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (myMode == BaseMode.None)
            {
                MetroMessageBox.Show(this, "신규 등록시 신규 버튼을 눌러주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(Common.CONSTR))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand
                    {
                        Connection = con
                    };

                    if (myMode == BaseMode.UPDATE)
                    {
                        cmd.CommandText = "UPDATE rentaltbl " +
                                          "   SET memberIdx = @memberIdx, " +
                                          "       bookIdx = @bookIdx, " +
                                          "       rentalDate = @rentalDate, " +
                                          "       returnDate = @returnDate " +
                                          " WHERE Idx = @Idx ";
                    }
                    else if (myMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = "INSERT INTO rentaltbl " +
                                          " ( " +
                                          "     memberIdx, " +
                                          "     bookIdx, " +
                                          "     rentalDate, " +
                                          "     returnDate " +
                                          " ) " +
                                          "VALUES " +
                                          " ( " +
                                          "     @memberIdx, " +
                                          "     @bookIdx, " +
                                          "     @rentalDate, " +
                                          "     @returnDate " +
                                          " ) ";
                    }


                    MySqlParameter paramMemberIdx = new MySqlParameter("@memberIdx", MySqlDbType.Int32);
                    paramMemberIdx.Value = metroComboBox1.SelectedValue;
                    cmd.Parameters.Add(paramMemberIdx);

                    MySqlParameter paramBookIdx = new MySqlParameter("@bookIdx", MySqlDbType.Int32);
                    paramBookIdx.Value = metroComboBox2.SelectedValue;
                    cmd.Parameters.Add(paramBookIdx);

                    MySqlParameter paramrentalDate = new MySqlParameter("@rentalDate", MySqlDbType.Date);
                    paramrentalDate.Value = metroDateTime1.Value;
                    cmd.Parameters.Add(paramrentalDate);

                    MySqlParameter paramreturnDate = new MySqlParameter("@rereturnDate", MySqlDbType.Date);
                    if (myMode == BaseMode.INSERT)
                    {
                        paramreturnDate.Value = null;
                    }
                    else
                    {
                        paramreturnDate.Value = metroDateTime2.Value;
                    }
                    cmd.Parameters.Add(paramreturnDate);



                    var result = cmd.ExecuteNonQuery();

                    if (myMode == BaseMode.INSERT)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 신규 입력되었습니다.", "신규 입력");
                    }
                    else if (myMode == BaseMode.UPDATE)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 저장되었습니다.", "저장");
                    }
                    else if (myMode == BaseMode.DELETE)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 삭제되었습니다.", "삭제");
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"에러 발생 {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //UpdateData();
            }
        }
        #endregion
    }
}
