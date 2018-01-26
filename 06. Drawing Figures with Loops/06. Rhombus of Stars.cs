using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rombus
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine());

            for(int i=inpt-1; i>0; i--)
            {
                Console.Write(new string(' ',i-1));
                for (int p = inpt - i; p > 0; p--) Console.Write(" *");

                Console.WriteLine("");
            }

            Console.Write('*');

            for (int i = 0; i < inpt-1; i++) Console.Write(" *");

            Console.WriteLine("");

            for (int i = 1; i < inpt; i++)
            {
                Console.Write(new string(' ', i -1));
                for (int p = inpt - i; p > 0; p--) Console.Write(" *");

                Console.WriteLine("");
            }

        }
    }
}
