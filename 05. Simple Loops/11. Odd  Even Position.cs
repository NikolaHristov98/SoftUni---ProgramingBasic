using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Odd_even_pos
{
    class Program
    {
        static void Main(string[] args)
        {
            float oddSum = 0,
                  oddMin=10000000000.0f,
                  oddMax= -10000000000.0f,
                  evenSum = 0,
                  evenMin = 10000000000.0f,
                  evenMax = -10000000000.0f,
                  inpt2;

            int inpt1 = int.Parse(Console.ReadLine());

            bool evenNo = true,
                 oddNo = true;

            for (int i = 1; i <= inpt1; i++)
            {
                if ((i % 2) == 1)
                {
                    if (oddNo) oddNo = false;

                    inpt2 = float.Parse(Console.ReadLine());

                    if (oddMin > inpt2) oddMin = inpt2;
                    if (oddMax < inpt2) oddMax = inpt2;

                    oddSum += inpt2;
                }
                else
                {
                    if (evenNo) evenNo = false;

                    inpt2 = float.Parse(Console.ReadLine());

                    if (evenMin > inpt2) evenMin = inpt2;
                    if (evenMax < inpt2) evenMax = inpt2;

                    evenSum += inpt2;
                }
            }

            Console.WriteLine("OddSum={0}",oddSum);
            Console.Write("OddMin=");
            if (oddNo) Console.WriteLine("No");
            else Console.WriteLine(oddMin);
            Console.Write("OddMax=");
            if (oddNo) Console.WriteLine("No");
            else Console.WriteLine(oddMax);
            Console.WriteLine("EvenSum={0}", evenSum);
            Console.Write("EvenMin=");
            if (evenNo) Console.WriteLine("No");
            else Console.WriteLine(evenMin);
            Console.Write("EvenMax=");
            if (evenNo) Console.WriteLine("No");
            else Console.WriteLine(evenMax);

        }
    }
}
