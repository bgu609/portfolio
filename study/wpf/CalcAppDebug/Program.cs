using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAppDebug
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            double a = 4.5, b = 2.5;
            double result = calc.Add(a, b);
            Console.WriteLine($"{result}");
            double result2 = calc.Sub(a, b);
            Console.WriteLine($"{result2}");
            double result3 = calc.Mul(a, b);
            Console.WriteLine($"{result3}");
            double result4 = calc.Div(a, b);
            Console.WriteLine($"{result4}");
        }

        public class Calculator
        {
            public Calculator()
            {
            }

            public double Add(double a, double b)
            {
                double result = 0;
                result = a + b;
                return result;
            }

            public double Div(double a, double b)
            {
                double result = 0;
                result = a / b;
                return result;
            }

            public double Mul(double a, double b)
            {
                double result = 0;
                result = a * b;
                return result;
            }

            public double Sub(double a, double b)
            {
                return a - b;
            }
        }
    }
}
