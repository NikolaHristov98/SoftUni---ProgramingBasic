﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 1; i <= length; i++)
            {
                num *= i;
            }

            Console.WriteLine(num);
        }
    }
}
