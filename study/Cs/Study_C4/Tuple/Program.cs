using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = ( "슈퍼맨", 56, "크립톤" );
            Console.WriteLine($"{a.Item1}, {a.Item2}, {a.Item3}");

            var b = (Name: "배기웅", Age: 44, Home: "김해");
            Console.WriteLine($"{b.Age}, {b.Home}, {b.Name}");

            b = a;
            Console.WriteLine($"{b.Age}, {b.Home}, {b.Name}");

            var (Name, Age, Home) = b;
            Console.WriteLine($"{Age}, {Home}, {Name}");
        }

    }
}
