using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine()),
                last = 0,
                curr = 1,
                buff;
            for (int i = 0; i < inpt; i++)
            {
                buff = curr;
                curr += last;
                last = buff;
            }

            Console.WriteLine(curr);
        }
    }
}
