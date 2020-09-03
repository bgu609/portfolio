using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambda
{
    class Program
    {
        delegate int Calculate(int a, int b);
        delegate string Concatnate(string[] args);

        #region delegate 방식
        /*
        static int Plus(int a, int b)
        {
            return a + b;
        }

        static string Strjoin(string[] args)
        {
            string result = "";
            foreach (var item in arr)
            {
                result += $"{item}";
            }
            return result;
        }
        */
        #endregion

        static void Main(string[] args)
        {
            //Calculate calc = new Calculate(Plus);
            Calculate calc = (a, b) => a + b;
            Console.WriteLine(calc(3, 4));

            //Concatnate concat = new Concatnate(Strjoin);
            Concatnate concat = (arr) =>
            {
                string result = "";
                foreach (var item in arr)
                {
                    result += $"{item}";
                }
                return result;
            };
            Console.WriteLine(concat(args));
        }
    }
}
