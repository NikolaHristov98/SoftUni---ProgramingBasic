using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inpt; i++)
            {
                if (i == 1 || i == inpt) Console.Write('+');
                else Console.Write('|');
                for (int p = 0; p < inpt-2; p++)
                {
                    Console.Write(" -");
                }
                
                if (i == 1 || i == inpt) Console.WriteLine( " +");
                else Console.WriteLine(" |");
            }
        }
    }
}
