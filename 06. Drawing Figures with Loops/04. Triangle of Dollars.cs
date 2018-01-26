using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolar_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine());

            for (int i = 0; i < inpt; i++)
            {
                Console.Write("$");
                for (int p = 0; p < i; p++)
                {
                    Console.Write(" $");
                }
                
                Console.WriteLine("");
            }
            
        }
    }
}
