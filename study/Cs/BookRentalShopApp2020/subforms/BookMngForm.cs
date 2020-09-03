using System;
using System.Collections.Generic;
using System.Data;
using System.Security.AccessControl;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace BookRentalShopApp2020.subforms
{
    public partial class BookMngForm : MetroForm
    {
        private readonly string strConnectionString = "Data Source=localhost; Port=3306; database=bookrentalshop; Uid=root; Password=epfls+358471;";

        public enum BaseMode
        {
            None,
            INSERT,
            UPDATE,
            SELECT,
            DELETE
        }

        BaseMode myMode = BaseMode.None;

        public BookMngForm()
        {
            InitializeComponent();
        }

        private void tableForm_Load(object sender, EventArgs e)
        {
            UpdateCboDivision();
            InitControls();

            try
            {
                using (MySqlConnection con = new MySqlConnection(strConnectionString)) //Commons.CONNSTR
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand
                    {
                        Connection = con
                    };

                    string strQuery = "SELECT b.Idx, " +
                                      "       b.Author, " +
                                      //"       b.Division, " +
                                      "       d.Names AS DivisionName, " +
                                      "       b.Names, " +
                                      "       b.ReleaseDate, " +
                                      "       b.ISBN, " +
                                      "       b.Price " +
                                      "  FROM bookstbl AS b " +
                                      " INNER JOIN divtbl AS d " +
                                      "  ON b.Division = d.Division " +
                                      " ORDER BY b.Idx ASC ";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "bookstbl");

                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "bookstbl";

                    /*
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    dataGridView1.Rows.Clear();

                    foreach (MySqlDataReader item in reader)
                    {
                        dataGridView1.Rows.Add(
                            item["Division"].ToString(),
                            item["Names"].ToString()
                            );
                    }*/
                }
                SetColumnHeaders();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"에러 발생 {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCboDivision()
        {
            using (MySqlConnection con = new MySqlConnection(strConnectionString)) //Commons.CONNSTR
            {
                con.Open();

                string strQuery = "SELECT Division, Names FROM divTbl ";

                MySqlCommand cmd = new MySqlCommand(strQuery, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, string> temp = new Dictionary<string, string>();
                temp.Add("0", "선택");
                while(reader.Read())
                {
                    temp.Add(reader[0].ToString(), reader[1].ToString());
                }

                CboDivision.DataSource = new BindingSource(temp, null);
                CboDivision.DisplayMember = "Value";
                CboDivision.ValueMember = "Key";
                CboDivision.SelectedIndex = 0;
            }
        }

        private void SetColumnHeaders()
        {
            DataGridViewColumn column;
            
            column = dataGridView1.Columns[0];
            column.Width = 50;
            column.HeaderText = "번호";

            column = dataGridView1.Columns[1];
            column.Width = 150;
            column.HeaderText = "저자명";

            column = dataGridView1.Columns[2];
            column.Width = 100;
            column.HeaderText = "장르";

            column = dataGridView1.Columns[3];
            column.Width = 200;
            column.HeaderText = "책 이름";

            column = dataGridView1.Columns[4];
            column.Width = 200;
            column.HeaderText = "출간일";

            column = dataGridView1.Columns[5];
            column.Width = 150;
            column.HeaderText = "ISBN";

            column = dataGridView1.Columns[6];
            column.Width = 100;
            column.HeaderText = "가격";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DataGridViewRow data = dataGridView1.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString();
                TxtAuthor.Text = data.Cells[1].Value.ToString();

                CboDivision.SelectedIndex = CboDivision.FindString(data.Cells[2].Value.ToString());
                //CboDivision.SelectedValue = data.Cells[2].Value;

                TxtNames.Text = data.Cells[3].Value.ToString();

                DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
                DtpReleaseDate.Format = DateTimePickerFormat.Custom;
                DtpReleaseDate.Value = DateTime.Parse(data.Cells[4].Value.ToString());

                TxtIsbn.Text = data.Cells[5].Value.ToString();
                TxtPrice.Text = data.Cells[6].Value.ToString();

                TxtIdx.ReadOnly = true;

                myMode = BaseMode.UPDATE;
            }
        }

        private void Savedata()
        {
            if (string.IsNullOrEmpty(TxtAuthor.Text) || CboDivision.SelectedIndex < 1 || string.IsNullOrEmpty(TxtNames.Text) || string.IsNullOrEmpty(TxtIsbn.Text))
            {
                MetroMessageBox.Show(this, "빈값은 넣을 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(myMode == BaseMode.None)
            {
                MetroMessageBox.Show(this, "신규 등록시 신규 버튼을 눌러주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(strConnectionString)) //Commons.CONNSTR
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand
                    {
                        Connection = con
                    };

                    if(myMode == BaseMode.UPDATE)
                    {
                        cmd.CommandText = "UPDATE bookstbl " +
                                          "   SET Author        = @Author, " +
                                          "       Division      = @Division, " +
                                          "       Names         = @Names, " +
                                          "       ReleaseDate   = @ReleaseDate, " +
                                          "       ISBN          = @ISBN, " +
                                          "       Price         = @Price " +
                                          " WHERE Idx = @Idx ";
                    }
                    else if(myMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = "INSERT INTO bookstbl " +
                                          "  ( " +
                                          "      Idx, " +
                                          "      Author, " +
                                          "      Division, " +
                                          "      Names, " +
                                          "      ReleaseDate, " +
                                          "      ISBN, " +
                                          "      Price" +
                                          "  ) " +
                                          "  VALUES " +
                                          "  ( " +
                                          "      @Idx, " +
                                          "      @Author, " +
                                          "      @Division, " +
                                          "      @Names, " +
                                          "      @ReleaseDate, " +
                                          "      @ISBN, " +
                                          "      @Price " +
                                          "  ) ";
                    }


                    MySqlParameter paramAuthor = new MySqlParameter("@Author", MySqlDbType.VarChar, 45)
                    {
                        Value = TxtAuthor.Text
                    };
                    cmd.Parameters.Add(paramAuthor);

                    MySqlParameter paramDivision = new MySqlParameter("@Division", MySqlDbType.VarChar, 4)
                    {
                        Value = CboDivision.SelectedValue
                    };
                    cmd.Parameters.Add(paramDivision);

                    MySqlParameter paramNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 100)
                    {
                        Value = TxtNames.Text
                    };
                    cmd.Parameters.Add(paramNames);

                    MySqlParameter paramReleaseDate = new MySqlParameter("@ReleaseDate", MySqlDbType.Date)
                    {
                        Value = DtpReleaseDate.Value
                    };
                    cmd.Parameters.Add(paramReleaseDate);

                    MySqlParameter paramISBN = new MySqlParameter("@ISBN", MySqlDbType.VarChar, 13)
                    {
                        Value = TxtIsbn.Text
                    };
                    cmd.Parameters.Add(paramISBN);

                    MySqlParameter paramPrice = new MySqlParameter("@Price", MySqlDbType.Decimal)
                    {
                        Value = TxtPrice.Text
                    };
                    cmd.Parameters.Add(paramPrice);

                    MySqlParameter paramIdx = new MySqlParameter("@Idx", MySqlDbType.Int32)
                    {
                        Value = TxtIdx.Text
                    };
                    cmd.Parameters.Add(paramIdx);



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

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{myMode}");
            Savedata();
            InitControls();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            TxtIdx.Text = string.Empty;
            TxtAuthor.Text = TxtIsbn.Text = TxtNames.Text = TxtPrice.Text = string.Empty;
            CboDivision.SelectedIndex = 0;
            DtpReleaseDate.Value = DateTime.Now;
            TxtIdx.ReadOnly = true;

            TxtIdx.Focus();

            myMode = BaseMode.INSERT;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(myMode != BaseMode.UPDATE)
            {
                MetroMessageBox.Show(this, "삭제할 데이터를 선택하세요", "알림");
                return;
            }

            myMode = BaseMode.DELETE;
            Savedata();
            InitControls();
        }

        private void InitControls()
        {
            TxtIdx.Text = TxtAuthor.Text = TxtIsbn.Text = TxtNames.Text = TxtPrice.Text = string.Empty;
            CboDivision.SelectedIndex = 0;
            TxtIdx.ReadOnly = true;

            TxtIdx.Focus();

            DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
            DtpReleaseDate.Value = DateTime.Now;

            #region cbo예시
            /*
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("선택", "00");
            dic.Add("서울특별시", "11");
            dic.Add("부산광역시", "21");
            dic.Add("대구광역시", "22");
            dic.Add("인천광역시", "23");
            dic.Add("광주광역시", "24");
            dic.Add("대전광역시", "25");

            CboDivision.DataSource = new BindingSource(dic, null);
            CboDivision.DisplayMember = "Key";
            CboDivision.ValueMember = "Value";
            */
            #endregion


        }

        #region 삭제처리 함수
        /*private void DeleteProcess()
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

                    cmd.CommandText = "DELETE FROM divtbl " +
                                      " WHERE Division = @Division ";

                    MySqlParameter paramDivision = new MySqlParameter("@Division", MySqlDbType.VarChar);
                    paramDivision.Value = TxtDivision.Text;
                    cmd.Parameters.Add(paramDivision);

                    var result = cmd.ExecuteNonQuery();

                    MetroMessageBox.Show(this, $"{result}건이 삭제되었습니다.", "삭제");
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
        }*/
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            InitControls();
        }

        private void CboDivision_SelectedIndexChanged(object sender, EventArgs e)
        {


            /*
            if(CboDivision.SelectedIndex > 0)
            {
                MessageBox.Show(CboDivision.SelectedValue.ToString());
            }*/
        }
    }
}
