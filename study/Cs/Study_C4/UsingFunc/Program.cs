using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Func 예제
            Func<int> func1 = () => 10; //{ return 10; };
            Console.WriteLine($"{func1()}");

            Func<int, int> func2 = (x) => { return x * 2; };
            Console.WriteLine(func2(4));

            try
            {
                Func<double, double, int> func3 = (x, y) => {
                    if (y == 0)
                    {
                        throw new Exception("Divide by zero");
                    }
                    return (int)(x / y);
                };
                Console.WriteLine(func3(22, 1.3));
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            #endregion

            Action act1 = () => { Console.WriteLine("act1()"); };
            act1();

            int result = 0;
            Action<int> act2 = (x) => { result = x * x; };
            act2(5);
            Console.WriteLine($"result : {result}");

            Action<double, double> act3 = (x, y) =>
            {
                double pi = x / y;
                Console.WriteLine($"{x},{y}, pi : {pi}");
            };
            act3(22.0, 7.0);
        }
    }
}
