using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine());

            for(int i=0; i<inpt; i++)
            {
                if (i == 0 || i == inpt - 1)
                {
                    Console.Write(new string('*', inpt*2));
                    Console.Write(new string(' ', inpt));
                    Console.Write(new string('*', inpt * 2));
                }
                else
                {
                    Console.Write('*');
                    Console.Write(new string('/', inpt * 2-2));
                    Console.Write('*');
                    if (i == (Math.Ceiling((double)inpt/2-1))) Console.Write(new string('/',inpt));
                    else Console.Write(new string(' ', inpt));
                    Console.Write('*');
                    Console.Write(new string('/', inpt * 2 - 2));
                    Console.Write('*');
                }

                Console.WriteLine("");

            }
        }
    }
}
