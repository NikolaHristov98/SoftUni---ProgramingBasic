using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine());

            for (int i = 0; i <= inpt; i++)
            {
                if (i%2==0) Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}