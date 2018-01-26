using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareNxN
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine());

            for (int i = 0; i < inpt; i++)
            {
                Console.Write("*");
                for (int i1 = 0; i1 < inpt-1; i1++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("");
            }
        }
    }
}
