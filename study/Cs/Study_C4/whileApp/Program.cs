using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            while(i > 0)
            {
                Console.WriteLine($"{i--}");
            }

            List<string> strings = new List<string>();
            strings.Add("Hello");
            strings.Add("Bye");
            strings.Add("Hey");
            List<string> subs = new List<string> { "Banana", "Strawberry" };
            strings.AddRange(subs);

            var j = 0;
            foreach (var item in strings)
            {
                Console.WriteLine($"{++j}번째 item : {item}");
            }
        }
    }
}
