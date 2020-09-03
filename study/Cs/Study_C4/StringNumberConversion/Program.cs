using System;

namespace StringNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12345;
            string b = a.ToString();
            Console.WriteLine($"b={b}");

            string e = "123456";
            int f;
            if(int.TryParse(e, out f)) //Convert.ToInt32(e);
            {
                Console.WriteLine($"f={f}");
            }

            string g = "3,141592";
            float h = float.Parse(g);
            Console.WriteLine($"h={h}");
        }
    }
}
