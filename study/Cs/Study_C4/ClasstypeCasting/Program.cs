using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasstypeCasting
{
    class Program
    {
        class Mammel
        {
            public void Norse()
            {
                Console.WriteLine("Norse()");
            }
        }

        class Dog:Mammel
        {
            public void Bark()
            {
                Console.WriteLine("Bark()");
            }
        }

        class Cat : Mammel
        {
            public void Mew()
            {
                Console.WriteLine("Mew()");
            }
        }
        static void Main(string[] args)
        {
            Mammel mammel = new Dog();
            Dog dog;

            if(mammel is Dog)
            {
                dog = mammel as Dog;
                dog.Bark();
            }
        }
    }
}
