using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1__Equal_element_from_group_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt1 = int.Parse(Console.ReadLine()) - 1,
                inpt2,
                sum=0,
                biggest = int.Parse(Console.ReadLine());
            sum += biggest;

            for (int i = 0; i < inpt1; i++)
            {
                inpt2 = int.Parse(Console.ReadLine());
                sum += inpt2;    

                if (biggest < inpt2) biggest = inpt2;
            }

            sum -= biggest;

            if (sum == biggest) Console.WriteLine("Yes Sum = {0}", sum);
            else Console.WriteLine("No Diff = {0}", Math.Abs(sum-biggest));

        }
    }
}
