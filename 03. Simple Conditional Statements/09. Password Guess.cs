using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpt = Console.ReadLine();

            if (inpt == "s3cr3t!P@ssw0rd") Console.WriteLine("Welcome"); 
            else Console.WriteLine("Wrong password!");
        }
    }
}
