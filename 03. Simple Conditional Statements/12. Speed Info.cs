using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            double inpt1 = double.Parse(Console.ReadLine());

            if (inpt1 <= 10) Console.WriteLine("slow");
            else if (inpt1 > 10 && inpt1 <= 50) Console.WriteLine("average");
            else if (inpt1 > 50 && inpt1 <= 150) Console.WriteLine("fast");
            else if (inpt1 > 150 && inpt1 <= 1000) Console.WriteLine("ultra fast");
            else Console.WriteLine("extremely fast");

        }
    }
}
