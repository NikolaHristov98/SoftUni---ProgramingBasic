using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.String_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine());
            int num = 1;

            while( inpt >= num)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
