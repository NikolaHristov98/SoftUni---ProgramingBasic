using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Equal_pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt1 = int.Parse(Console.ReadLine()),
                inpt2, inpt3,
                prevsum = 0,
                currsum=0,
                maxdiff = 0;

            inpt2 = int.Parse(Console.ReadLine());
            inpt3 = int.Parse(Console.ReadLine());
            prevsum = inpt2 + inpt3;

            for (int i = 0; i < inpt1-1; i++)
            {
                inpt2 = int.Parse(Console.ReadLine());
                inpt3 = int.Parse(Console.ReadLine());
                currsum = inpt2 + inpt3;
                if (currsum != prevsum) maxdiff = Math.Abs(prevsum - currsum);
                prevsum = currsum;
            }

            if (maxdiff == 0) Console.WriteLine("Yes, value={0}",prevsum);
            else Console.WriteLine("No, maxdiff={0}",maxdiff);
        }
    }
}
