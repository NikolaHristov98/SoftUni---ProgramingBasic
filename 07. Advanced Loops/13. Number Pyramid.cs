using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Pyramid_from_nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine()),
                curr = 1;

            for (int i = 1; curr<=inpt; i++)
            {
                Console.Write(curr);
                curr++;
                for (int p=1; p < i&&curr<=inpt; p++)
                {

                    Console.Write(" " + curr);
                    curr++;
                }

                Console.WriteLine("");
            }
        }
    }
}
