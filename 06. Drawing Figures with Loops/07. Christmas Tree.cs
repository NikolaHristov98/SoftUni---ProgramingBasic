using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine());

            for(int i=0; i<=inpt;i++)
            {
                Console.Write(new string(' ', inpt-i));
                Console.Write(new string('*', i));
                Console.Write(' ');
                Console.Write('|');
                Console.Write(' ');
                Console.Write(new string('*', i));
                Console.WriteLine("");
            }
        }
    }
}
