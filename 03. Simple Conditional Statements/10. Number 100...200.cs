using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_100._._._200
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine());
            if (inpt < 100) Console.WriteLine("Less than 100");
            else if (inpt > 200) Console.WriteLine("Greater than 200");
            else Console.WriteLine("Between 100 and 200");
        }
    }
}
