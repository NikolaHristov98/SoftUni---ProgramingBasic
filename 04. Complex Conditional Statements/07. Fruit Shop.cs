using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] prices = new float[2, 7] { { 2.50f, 1.20f, 0.85f, 1.45f, 2.70f, 5.50f, 3.85f },{ 2.70f, 1.25f, 0.90f, 1.60f, 3.00f, 5.60f,  4.20f } };
            int x, y;
            string product = Console.ReadLine(),
                   day = Console.ReadLine();
            float quantity = float.Parse(Console.ReadLine());


            if (day == "Saturday" || day == "Sunday") x = 1;
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday") x = 0;
            else
            {
                Console.WriteLine("error");
                return;
            }

                if (product == "banana") y = 0;
            else if (product == "apple") y = 1;
            else if (product == "orange") y = 2;
            else if (product == "grapefruit") y = 3;
            else if (product == "kiwi") y = 4;
            else if (product == "pineapple") y = 5;
            else if (product == "grapes") y = 6;
            else
            {
                Console.WriteLine("error");
                return;
            }
            Console.WriteLine("{0:f2}",prices[x,y]*quantity);
        }
    }
}
