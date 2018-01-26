using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_Lowest_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt1 = int.Parse(Console.ReadLine()) - 1,
                   inpt2,
                   smallest = int.Parse(Console.ReadLine());

            for (int i = 0; i < inpt1; i++)
            {
                inpt2 = int.Parse(Console.ReadLine());

                if (smallest > inpt2) smallest = inpt2;
            }

            Console.WriteLine(smallest);

        }
    }
}
