using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] commisions = new float[3, 4] { { 5, 7, 8, 12 }, { 4.5f, 7.5f, 10, 13 }, { 5.5f, 8, 12, 14.5f } };
            string city = Console.ReadLine();
            float sales = float.Parse(Console.ReadLine());
            int x, y;

            if (city == "Sofia") x = 0;
            else if (city == "Varna") x = 1;
            else if (city == "Plovdiv") x = 2;
            else
            {
                Console.WriteLine("error");
                return;
            }

            if (sales >= 0 && sales <= 500) y = 0;
            else if (sales > 500 && sales <= 1000) y = 1;
            else if (sales > 1000 && sales <= 10000) y = 2;
            else if (sales > 10000) y = 3;
            else
            {
                Console.WriteLine("error");
                return;
            }

            Console.WriteLine("{0:f2}",commisions[x,y]*sales/100);
        }
    }
}
