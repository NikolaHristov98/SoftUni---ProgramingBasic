using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.NOD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine());

            while (a !=0&&b!=0)
            {
                if (a > b) a %= b;
                else       b %= a;
            }
            if(a!=0) Console.WriteLine(a);
            else Console.WriteLine(b);
        }
    }
}
