using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
           
            decimal inpt = decimal.Parse(Console.ReadLine());
            string from = Console.ReadLine(),
                   to = Console.ReadLine();

            decimal end = (inpt / toIndex(from)) * toIndex(to);

            Console.WriteLine("{0:F8}",end);



        }

        static decimal toIndex(string metric)
        {
            if (metric == "m") return 1;
            else if (metric == "mm") return 1000;
            else if (metric == "cm") return 100;
            else if (metric == "mi") return 0.000621371192M;
            else if (metric == "in") return 39.3700787M;
            else if (metric == "km") return 0.001M;
            else if (metric == "ft") return 3.2808399M;
            else return 1.0936133M;

        }
    }
}
