using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double inpt1 = double.Parse(Console.ReadLine()),
                   inpt2 = double.Parse(Console.ReadLine()),
                   inpt3 = double.Parse(Console.ReadLine());

            if (inpt1 == inpt3 && inpt2 == inpt3) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}
