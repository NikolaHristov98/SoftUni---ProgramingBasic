using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine()),
                num_roof = (inpt + 1) / 2,
                num_floor = inpt / 2,
                num_stars = 0;
               

            if (inpt % 2 == 1) num_stars = 1;
            else num_stars = 2;

            for(int i=0; i<num_roof; i++)
            {
                Console.Write(new string('-', (inpt - num_stars)/2));
                Console.Write(new string('*', num_stars));
                Console.Write(new string('-', (inpt - num_stars)/2));
                num_stars += 2;
                Console.WriteLine("");
            }

            for(int i = 0; i < num_floor; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', inpt-2));
                Console.Write('|');
                Console.WriteLine("");
            }
        }
    }
}
