using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Num_in_range
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number int the range [1...100]:");
                int inpt = int.Parse(Console.ReadLine());

                if (inpt >= 1 && inpt <= 100)
                {
                    Console.WriteLine("The number is: {0}",inpt);
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
