using MVVM_APP.Helpers;
using System;

namespace MVVM_APP.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        string email;
        public string Email
        {
            get => email; // get { return email; }
            set
            {
                if (Commons.IsvalidEmail(value))
                    email = value;
                else
                    throw new Exception("Invalid email");
            }
        }

        DateTime date;
        public DateTime Date
        {
            get => date; // get { return date; }
            set
            {
                var result = Commons.CalcAge(value);
                if (result < 0)
                    throw new Exception("Invalid Date");
                else
                    date = value;
            }
        }

        public Person(string firstName, string lastName, string email, DateTime date)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Date = date;
        }

        public bool IsBirthday // 추가 속성
        {
            get
            {
                return DateTime.Now.Month == Date.Month && DateTime.Now.Day == Date.Day;
            }
        }

        public bool IsAdult // 추가 속성
        {
            get
            {
                return Commons.CalcAge(date) > 18;
            }
        }

        public string Zodiac { get { return Commons.CalcZodiac(date); } } // 추가 속성

        public string ChnZodiac { get { return Commons.CalcChnZodiac(date); } } // 추가 속성
    }
}
