using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Table_with_nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine());

            for(int i=1; i<=inpt; i++)
            {
                bool isDecreasing = false;
                int num = i;
                Console.Write(num);
                for (int p = 0; p < inpt-1; p++)
                {
                    if (num == inpt) isDecreasing = true;

                    if (isDecreasing) num--;
                    else num++;

                    Console.Write(" "+num);
                }
                Console.WriteLine("");
            }
                
        }
    }
}
