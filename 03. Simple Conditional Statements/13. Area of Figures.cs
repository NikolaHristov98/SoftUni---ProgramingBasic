using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double inpt1, inpt2, area;

            if (figure == "square")
            {
                inpt1 = double.Parse(Console.ReadLine());
                area = inpt1 * inpt1;
                area = Math.Round(area, 3);
                Console.WriteLine(area);

            }
            else if (figure == "rectangle")
            {
                inpt1 = double.Parse(Console.ReadLine());
                inpt2 = double.Parse(Console.ReadLine());
                area = inpt1 * inpt2;
                area = Math.Round(area, 3);
                Console.WriteLine(area);
            }
            else if (figure == "circle")
            {
                inpt1 = double.Parse(Console.ReadLine());
                area = inpt1*inpt1 * Math.PI;
                area = Math.Round(area, 3);
                Console.WriteLine(area);
            }
            else
            {
                inpt1 = double.Parse(Console.ReadLine());
                inpt2 = double.Parse(Console.ReadLine());
                area = inpt1 * inpt2 / 2;
                area = Math.Round(area, 3);
                Console.WriteLine(area);
            }
        }
    }
}
