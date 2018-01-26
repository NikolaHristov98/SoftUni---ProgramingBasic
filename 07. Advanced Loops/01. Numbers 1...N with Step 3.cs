using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_to_N_past_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inpt; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
