using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_Odd_even_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt1 = int.Parse(Console.ReadLine()),
                sumO = 0,
                sumE = 0;

            for (int i = 1; i <= inpt1; i++)
            {
                if ((i % 2)==1) sumO += int.Parse(Console.ReadLine());
                else sumE += int.Parse(Console.ReadLine());
            }

            if (sumO == sumE) Console.WriteLine("Yes, sum = {0}", sumO);
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sumO - sumE));
            }

        }
    }
}
