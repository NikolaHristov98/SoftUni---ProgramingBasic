using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpt1 = Console.ReadLine(),
                   inpt2 = Console.ReadLine();
            inpt1 = inpt1.ToLower();
            inpt2 = inpt2.ToLower();

            if (inpt1 == inpt2) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}
