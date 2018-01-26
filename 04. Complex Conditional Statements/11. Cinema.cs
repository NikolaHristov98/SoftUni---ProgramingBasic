using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            float price;

            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine()),
                collums = int.Parse(Console.ReadLine());

            if (type == "Premiere") price = 12;
            else if (type == "Normal") price = 7.5f;
            else price = 5;

            Console.WriteLine("{0:f2}",rows*collums*price);
        }
    }
}
