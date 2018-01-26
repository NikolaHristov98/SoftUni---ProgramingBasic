using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine()),
                minutes = int.Parse(Console.ReadLine());

            minutes += hours * 60+15;

            hours = minutes / 60;
            minutes = minutes % 60;

            if (hours >= 24) hours -= 24;

            Console.Write(hours+":");
            if (minutes < 10) Console.Write("0");
            Console.Write(minutes);

        }
    }
}
