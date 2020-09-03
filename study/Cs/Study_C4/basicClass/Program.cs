using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicClass
{
    class Cat
    {
        public string Name;
        public string Color;

        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void Meow()
        {
            Console.WriteLine($"{Name}, 야옹");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Color = "White";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "Black");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
