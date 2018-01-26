using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//programata perzapisana s tezi do 4ta
namespace Excellent_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt1 = int.Parse(Console.ReadLine()),
                inpt2 = int.Parse(Console.ReadLine());
            if (inpt1>= inpt2)
            {
                Console.WriteLine(inpt1);
            }
            else
            {
                Console.WriteLine(inpt2);
            }
        }
    }
}
