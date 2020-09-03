using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace intergerType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            sbyte a = sbyte.MinValue;
            byte b = byte.MaxValue;

            short c = short.MinValue;
            ushort d = ushort.MaxValue;

            int e = int.MinValue;
            uint f = uint.MaxValue;

            long g = long.MinValue;
            ulong h = ulong.MaxValue;
            ulong i = 200_0000_0000;
            Console.WriteLine(i)
            */

            byte a = 255;
            WriteLine($"a={a}");
            byte b = 0b1111_1111;
            WriteLine($"b={b}");
            byte c = 0xFF;
            WriteLine($"c={c}");
            byte d = byte.MaxValue;
            WriteLine($"d={d}");
            d += 1;
            WriteLine($"d={d}");
            float f= float.MaxValue;
        }
    }
}
