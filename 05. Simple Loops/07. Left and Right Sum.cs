using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_Left_and_right_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt1 = int.Parse(Console.ReadLine()),
                sumL = 0,
                sumR = 0;

            for (int i = 0; i < inpt1; i++)
            {
                sumL += int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < inpt1; i++)
            {
                sumR += int.Parse(Console.ReadLine());
            }

            if (sumL == sumR) Console.WriteLine("Yes, sum = {0}", sumL);
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sumL-sumR) );
            }
        }
    }
}
