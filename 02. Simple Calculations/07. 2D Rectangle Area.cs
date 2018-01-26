using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double  x1 = double.Parse(Console.ReadLine()),
                    y1 = double.Parse(Console.ReadLine()),
                    x2 = double.Parse(Console.ReadLine()),
                    y2 = double.Parse(Console.ReadLine());
            double a =Math.Abs( x1 - x2);
            double b = Math.Abs(y1 - y2);

            Console.WriteLine(a*b);
            Console.WriteLine(2*(a+b));

        }
    }
}
