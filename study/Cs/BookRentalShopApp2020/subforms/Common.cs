using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalShopApp2020.subforms
{
    class Common
    {
        public static string USERID = string.Empty;

        public static readonly string CONSTR = "Data Source=localhost; Port=3306; database=bookrentalshop; Uid=root; Password=epfls+358471;";

        /// <summary>
        /// MD5 암호화 메서드
        /// </summary>
        /// <param name="md5Hash">해시키값</param>
        /// <param name="input">평문 문자열</param>
        /// <returns>암호화된 문자열</returns>
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
