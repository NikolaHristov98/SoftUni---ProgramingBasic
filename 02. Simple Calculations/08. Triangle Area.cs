using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_area
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine()),
                   h = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(a*h/2, 2));
        }
    }
}
