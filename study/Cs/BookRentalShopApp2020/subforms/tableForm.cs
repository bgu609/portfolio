using System;
using System.Security.AccessControl;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace BookRentalShopApp2020.subforms
{
    public partial class tableForm : MetroForm
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

        public tableForm()
        {
            InitializeComponent();
        }

        private void tableForm_Load(object sender, EventArgs e)
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

                    cmd.CommandText = "SELECT * FROM divtbl ";

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    dataGridView1.Rows.Clear();

                    foreach (MySqlDataReader item in reader)
                    {
                        dataGridView1.Rows.Add(
                            item["Division"].ToString(),
                            item["Names"].ToString()
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"에러 발생 {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DataGridViewRow data = dataGridView1.Rows[e.RowIndex];
                TxtDivision.Text = data.Cells[0].Value.ToString();
                TxtNames.Text = data.Cells[1].Value.ToString();

                TxtDivision.ReadOnly = true;

                myMode = BaseMode.UPDATE;
            }
        }

        private void Savedata()
        {
            if (string.IsNullOrEmpty(TxtDivision.Text) || string.IsNullOrEmpty(TxtNames.Text))
            {
                MetroMessageBox.Show(this, "빈값은 넣을 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(myMode != BaseMode.None)
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
                        cmd.CommandText = "UPDATE divtbl " +
                                      " SET Names = @Names " +
                                      " WHERE Division = @Division; ";
                    }
                    else if(myMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = "INSERT INTO divtbl(Division, Names) " +
                                          " VALUES(@Division, @Names) ";
                    }
                    else if (myMode == BaseMode.DELETE)
                    {
                        cmd.CommandText = "DELETE FROM divtbl " +
                                          " WHERE Division = @Division ";
                    }

                    if (myMode == BaseMode.INSERT || myMode == BaseMode.UPDATE)
                    {
                        MySqlParameter paramNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 45);

                        paramNames.Value = TxtNames.Text;
                        cmd.Parameters.Add(paramNames);
                    }
                    MySqlParameter paramDivision = new MySqlParameter("@Division", MySqlDbType.VarChar);

                    paramDivision.Value = TxtDivision.Text;
                    cmd.Parameters.Add(paramDivision);

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
            Savedata();
            InitControls();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            TxtDivision.Text = TxtNames.Text = string.Empty;
            TxtDivision.ReadOnly = false;

            TxtDivision.Focus();

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
            TxtDivision.Text = TxtNames.Text = string.Empty;

            TxtDivision.Focus();

            myMode = BaseMode.None;
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
    }
}
