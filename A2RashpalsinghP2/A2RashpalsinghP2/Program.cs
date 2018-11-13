using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2RashpalsinghP2
{
    class Program
    {
        static double seq(double r, double pi)
        {
            double seq;
            seq = 4 / 3 * pi * r * r * r;
            return seq;
        }
        static double seq(double rad, double h, double pi)
        {
            double seq;
            seq = pi * rad * rad * h;
            return seq;
        }
        static int seq(int l, int b, int h)
        {
            int seq;
            seq = l * b * h;
            return seq;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for sphere ");
            Console.WriteLine("2 for cylinder ");
            Console.WriteLine("3 for rectangular prism");
            string x = Console.ReadLine();
            int y = int.Parse(x);

            if (y == 1)
            {
                Console.WriteLine("enter the value of radius");
                string o = Console.ReadLine();
                double r = double.Parse(o);
                double result;
                result = seq(3.14, r);
                Console.WriteLine(" volume of sphere is = " + result);
            }

            else if (y == 2)
            {
                Console.WriteLine("enter the value of radius");
                string j = Console.ReadLine();
                double c = double.Parse(j);
                Console.WriteLine("enter the value of height");
                string m = Console.ReadLine();
                double n = double.Parse(m);
                double res;
                res = seq(3.14, c, n);
                Console.WriteLine(" volume of cylinder is = " + res);
            }

            else if (y == 3)
            {
                Console.WriteLine("enter the value of length");
                string g = Console.ReadLine();
                int z = int.Parse(g);
                Console.WriteLine("enter the value of breadth");
                string v = Console.ReadLine();
                int b = int.Parse(v);
                Console.WriteLine("enter the value of height");
                string r = Console.ReadLine();
                int h = int.Parse(r);
                int result;
                result = seq(z, b, h);
                Console.WriteLine(" volume of rectangular prism is = " + result);
            }
        }
    }
}
