using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace BookRentalShopApp2020.subforms
{
    public partial class LoginForm : MetroForm
    {
        private readonly string strConnectionString = "Data Source=localhost; Port=3306; database=bookrentalshop; Uid=root; Password=epfls+358471;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void LoginProcess()
        {
            if(string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroMessageBox.Show(this, "아이디나 패스워드를 입력하세요!", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
                return;
            }

            string resultID = string.Empty;

            try
            {
                using (MySqlConnection con = new MySqlConnection(strConnectionString))
                {
                    con.Open();
                    
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT userid FROM usertbl " +
                                      " WHERE userid = @userID " +
                                      "   AND password = @password ";

                    MySqlParameter paramUserID = new MySqlParameter("@userID", MySqlDbType.VarChar);
                    paramUserID.Value = txtID.Text.Trim();
                    MySqlParameter paramPassword = new MySqlParameter("@password", MySqlDbType.VarChar);
                    var md5Hash = MD5.Create();
                    var cryptoPassword = Common.GetMd5Hash(md5Hash, txtPassword.Text.Trim());
                    paramPassword.Value = cryptoPassword; //txtPassword.Text.Trim();
                    
                    cmd.Parameters.Add(paramUserID);
                    cmd.Parameters.Add(paramPassword);
                    
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if(reader.HasRows)
                    {
                        resultID = reader["userid"] != null ? reader["userid"].ToString() : string.Empty;
                        Common.USERID = resultID; // 2020.07.20 12:30 추가
                        MetroMessageBox.Show(this, $"{resultID} 로그인 성공");
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "아이디나 패스워드를 정확히 입력하세요.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Text = txtPassword.Text = string.Empty;
                        txtID.Focus();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"DB 접속에러 : {ex.Message}", "로그인 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if(string.IsNullOrEmpty(resultID))
            {
                MetroMessageBox.Show(this, "아이디나 패스워드를 정확히 입력하세요.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Text = txtPassword.Text = string.Empty;
                txtID.Focus();
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOK_Click(sender, new EventArgs());
            }
        }
    }
}
