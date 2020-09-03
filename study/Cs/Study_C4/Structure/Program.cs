using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    struct Point3D
    {
        public int x;
        public int y;
        public int z;

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return string.Format($"{x}, {y}, {z}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point3D p3d1;
            p3d1.x = 10;
            p3d1.y = 20;
            p3d1.z = 40;
            Console.WriteLine(p3d1.ToString());
        }
    }
}
