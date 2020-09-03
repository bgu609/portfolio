using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingFrom
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Subject
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Using From
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10, };
            var result = from     n in numbers
                         where    n%2 == 0
                         orderby  n ascending
                         select   n;

            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            }
            #endregion
            #region Using profile
            List<Profile> profiles = new List<Profile>
            {
                new Profile {Name="정우성",Height=186},
                new Profile {Name="장동건",Height=182},
                new Profile {Name="원빈",Height=173},
                new Profile {Name="고현정",Height=172},
                new Profile {Name="이문세",Height=178},
                new Profile {Name="이승기",Height=181},
            };

            var newProfiles = from item in profiles
                              where item.Height < 175
                              orderby item.Name ascending
                              select new
                              {
                                  Name = item.Name,
                                  InchHeight = item.Height * 0.393
                              };

            foreach (var item in newProfiles)
            {
                Console.WriteLine($"'{item.Name}', {item.InchHeight} inch");
            }
            #endregion

            List<Subject> subjects = new List<Subject>
            {
                new Subject {Name="연두반", Score=new int[] {99,80,70,24,52} },
                new Subject {Name="분홍반", Score=new int[] {60,45,87,72} },
                new Subject {Name="파란반", Score=new int[] {92,30,85,94} },
                new Subject {Name="노랑반", Score=new int[] {90,88,0} },
            };

            var newSubject = from s in subjects
                             from d in s.Score
                             where d < 60
                             orderby s.Name
                             select new { s.Name, Lowest = d };

            foreach (var item in newSubject)
            {
                Console.WriteLine($"낙제 : {item.Name}, {item.Lowest}");
            }
        }
    }
}
