using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine()),
                rows = (int)Math.Ceiling((double)inpt / 2 )-1,
                posS1, posS2;


            if (inpt % 2 == 1)
            {
                posS1 = inpt / 2 + 1;
                posS2 = posS1;
            }
            else
            {
                posS1 = inpt / 2;
                posS2 = inpt / 2 + 1;
            }


            for (int i = 0; i < 2*rows+1; i++)
            {
                for (int p = 1 ; p <= inpt ; p++)
                {
                    if (p == posS1 || p == posS2) Console.Write('*');
                    else Console.Write('-');
                }


                if (i < rows )
                {
                    posS1--;
                    posS2++;
                }
                else
                {
                    posS1++;
                    posS2--;
                }
                Console.WriteLine("");
            }


            
        }
    }
}
