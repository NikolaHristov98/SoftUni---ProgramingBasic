using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (inpt < 2) isPrime = false;
            else
                for(int i = 2; i < inpt; i++)
                {
                    if (inpt % i == 0) isPrime = false;
                }

            if (isPrime) Console.WriteLine("Prime");
            else Console.WriteLine("Not Prime");
        }
    }
}
