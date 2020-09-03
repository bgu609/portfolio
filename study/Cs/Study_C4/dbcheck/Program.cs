using System;
using MySql.Data.MySqlClient;

namespace dbcheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string strConnectionString = "Data Source=localhost; Port=3306; database=bookrentalshop; Uid=root; Password=epfls+358471;";
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
                    paramUserID.Value = "admin";
                    MySqlParameter paramPassword = new MySqlParameter("@password", MySqlDbType.VarChar);
                    paramPassword.Value = "12345asdf";

                    cmd.Parameters.Add(paramUserID);
                    cmd.Parameters.Add(paramPassword);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if (reader.HasRows)
                    {
                        resultID = reader["userid"] != null ? reader["userid"].ToString() : string.Empty;
                        Console.WriteLine($"{resultID} 로그인 성공");
                    }
                    else
                    {
                        Console.WriteLine("아이디나 패스워드를 정확히 입력하세요. 로그인 실패");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error");
                Console.WriteLine(ex.ToString());
                return;
            }
        }
    }
}
