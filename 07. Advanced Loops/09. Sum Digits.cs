using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sum_of_nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine()),
                sum = 0;

            while (inpt != 0)
            {
                sum += inpt % 10;
                inpt /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
