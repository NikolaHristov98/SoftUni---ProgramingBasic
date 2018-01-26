using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());

            if (a >= 100 & a <= 200 || a == 0) return ;
            else Console.WriteLine("invalid");
        }
    }
}
