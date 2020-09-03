using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deepCopy
{
    class MyClass
    {
        public int Myfield1;
        public int Myfield2;

        public MyClass deepCopy()
        {
            MyClass newcopy = new MyClass
            {
                Myfield1 = this.Myfield1,
                Myfield2 = this.Myfield2
            };
            return newcopy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");
            {
                MyClass source = new MyClass
                {
                    Myfield1 = 10,
                    Myfield2 = 20
                };

                MyClass target = source;
                target.Myfield2 = 300;
                Console.WriteLine($"{source.Myfield1} {source.Myfield2}");
                Console.WriteLine($"{target.Myfield1} {target.Myfield2}");
            }

            Console.WriteLine("Deep Copy");
            {
                MyClass source = new MyClass
                {
                    Myfield1 = 10,
                    Myfield2 = 20
                };

                MyClass target = source.deepCopy();
                target.Myfield2 = 300;
                Console.WriteLine($"{source.Myfield1} {source.Myfield2}");
                Console.WriteLine($"{target.Myfield1} {target.Myfield2}");
            }
        }
    }
}
