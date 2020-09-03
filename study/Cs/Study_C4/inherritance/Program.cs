using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherritance
{
    class Parent
    {
        protected string Name { get; set; }

        public Parent(string name)
        {
            Name = name;
            Console.WriteLine($"{Name}.Base()");
        }

        public void BaseMethod()
        {
            Console.WriteLine($"{Name}.BaseMethod()");
        }
    }

    class Child : Parent
    {
        public Child(string name) : base(name)
        {
            Console.WriteLine($"{this.Name}.Child()");
        }

        public void DerivedMethod()
        {
            base.BaseMethod();
            Console.WriteLine($"{Name}.DerivedMethod()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent P = new Parent("p");
            P.BaseMethod();

            Child c = new Child("c");
            c.BaseMethod();

            Console.WriteLine("------------------------------");
            c.DerivedMethod();
        }
    }
}
