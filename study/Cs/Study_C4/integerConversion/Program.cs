using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integerConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = sbyte.MaxValue;
            Console.WriteLine($"a={a}");
            int b = a;
            Console.WriteLine($"b={b}");
            int x = 129;
            Console.WriteLine($"x={x}");
            sbyte y = (sbyte)x; // overflow
            Console.WriteLine($"y={y}");

            double pi = 3.1415926535;
            Console.WriteLine($"pi={pi}");
            float fpi = (float)pi;
            Console.WriteLine($"fpi={fpi}");
        }
    }
}
