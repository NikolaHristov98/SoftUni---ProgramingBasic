﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine(),
                   city = Console.ReadLine();
            float quantity = float.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (product == "coffee") Console.WriteLine( 0.5*quantity);
                else if (product == "water") Console.WriteLine(0.8*quantity);
                else if (product == "beer") Console.WriteLine(1.2*quantity);
                else if (product == "sweets") Console.WriteLine(1.45*quantity);
                else Console.WriteLine(1.60*quantity);
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee") Console.WriteLine(0.4 * quantity);
                else if (product == "water") Console.WriteLine(0.7 * quantity);
                else if (product == "beer") Console.WriteLine(1.15 * quantity);
                else if (product == "sweets") Console.WriteLine(1.30 * quantity);
                else Console.WriteLine(1.5 * quantity);
            }
            else
            {
                if (product == "coffee") Console.WriteLine(0.45 * quantity);
                else if (product == "water") Console.WriteLine(0.7 * quantity);
                else if (product == "beer") Console.WriteLine(1.1 * quantity);
                else if (product == "sweets") Console.WriteLine(1.35 * quantity);
                else Console.WriteLine(1.55 * quantity);
            }
        }
    }
}
