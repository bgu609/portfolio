using System;

namespace MVVM_APP.Helpers
{
    public class Commons
    {
        public static bool IsvalidEmail(string email)
        {
            string[] parts = email.Split('@');
            if (parts.Length != 2) return false;
            return parts[1].Split('.').Length == 2;
        }

        public static int CalcAge(DateTime date)
        {
            int middle;
            DateTime now = DateTime.Now;

            //만 나이 계산
            if (now.Month < date.Month || (now.Month == date.Month && now.Day < date.Day))
            {
                middle = now.Year - date.Year - 1; // 생일이 안 지난 경우
            }
            else
            {
                middle = now.Year - date.Year; // 생일이 지난 경우
            }
            return middle;
        }

        public static string CalcZodiac(DateTime date)
        {
            string result;

            switch (date.Month)
            {
                case 12 when date.Day > 24:
                case 1 when date.Day <= 19:
                    result = "염소자리";
                    break;
                case 1 when date.Day > 19:
                case 2 when date.Day <= 18:
                    result = "물병자리";
                    break;
                case 2 when date.Day > 18:
                case 3 when date.Day <= 20:
                    result = "물고기자리";
                    break;
                case 3 when date.Day > 20:
                case 4 when date.Day <= 19:
                    result = "양자리";
                    break;
                case 4 when date.Day > 19:
                case 5 when date.Day <= 20:
                    result = "황소자리";
                    break;
                case 5 when date.Day > 20:
                case 6 when date.Day <= 21:
                    result = "쌍둥이자리";
                    break;
                case 6 when date.Day > 21:
                case 7 when date.Day <= 22:
                    result = "게자리";
                    break;
                case 7 when date.Day > 22:
                case 8 when date.Day <= 22:
                    result = "사자자리";
                    break;
                case 8 when date.Day > 22:
                case 9 when date.Day <= 23:
                    result = "처녀자리";
                    break;
                case 9 when date.Day > 23:
                case 10 when date.Day <= 22:
                    result = "천칭자리";
                    break;
                case 10 when date.Day > 22:
                case 11 when date.Day <= 22:
                    result = "전갈자리";
                    break;
                default:
                    result = "궁수자리";
                    break;
            }
            //if ((date.Month == 12 && date.Day > 24) || (date.Month == 1 && date.Day <= 19))
            //    result = "염소자리";
            //else if ((date.Month == 1 && date.Day > 19) || (date.Month == 2 && date.Day <= 18))
            //    result = "물병자리";
            //else if ((date.Month == 2 && date.Day > 18) || (date.Month == 3 && date.Day <= 20))
            //    result = "물고기자리";
            //else if ((date.Month == 3 && date.Day > 20) || (date.Month == 4 && date.Day <= 19))
            //    result = "양자리";
            //else if ((date.Month == 4 && date.Day > 19) || (date.Month == 5 && date.Day <= 20))
            //    result = "황소자리";
            //else if ((date.Month == 5 && date.Day > 20) || (date.Month == 6 && date.Day <= 21))
            //    result = "쌍둥이자리";
            //else if ((date.Month == 6 && date.Day > 21) || (date.Month == 7 && date.Day <= 22))
            //    result = "게자리";
            //else if ((date.Month == 7 && date.Day > 22) || (date.Month == 8 && date.Day <= 22))
            //    result = "사자자리";
            //else if ((date.Month == 8 && date.Day > 22) || (date.Month == 9 && date.Day <= 23))
            //    result = "처녀자리";
            //else if ((date.Month == 9 && date.Day > 23) || (date.Month == 10 && date.Day <= 22))
            //    result = "천칭자리";
            //else if ((date.Month == 10 && date.Day > 22) || (date.Month == 11 && date.Day <= 22))
            //    result = "전갈자리";
            //else
            //    result = "궁수자리";

            return result;
        }

        public static string CalcChnZodiac(DateTime date)
        {
            int remainder = date.Year % 12;
            switch(remainder)
            {
                case 0:
                    return "원숭이띠";
                case 1:
                    return "닭띠";
                case 2:
                    return "개띠";
                case 3:
                    return "돼지띠";
                case 4:
                    return "쥐띠";
                case 5:
                    return "소띠";
                case 6:
                    return "호랑이띠";
                case 7:
                    return "토끼띠";
                case 8:
                    return "용띠";
                case 9:
                    return "뱀띠";
                case 10:
                    return "말띠";
                case 11:
                    return "양띠";
                default:
                    return "잡띠";
            }
        }
    }
}
