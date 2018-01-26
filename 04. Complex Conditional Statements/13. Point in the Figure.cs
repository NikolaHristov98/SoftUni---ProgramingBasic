using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_shape
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine()),
                x = int.Parse(Console.ReadLine()),
                y = int.Parse(Console.ReadLine());

            int x1 = 0, y1 = 0, x2 = 3 * h, y2 = h, x3 = h, y3 = h, x4 = 2 * h, y4 = 4 * h;

            string posRec1 = WhereIsPoint(x, y, x1, y1, x2, y2),
                   posRec2 = WhereIsPoint(x, y, x3, y3, x4, y4);

            if (posRec1 == "Inside" || posRec2 == "Inside") Console.WriteLine("inside");
            else if (posRec1 == "Outside" && posRec2 == "Outside") Console.WriteLine("outside");
            else if (y == h && (x > h && x < 2 * h)) Console.WriteLine("inside");
            else Console.WriteLine("border");

        }

        static string WhereIsPoint(int pX, int pY, int recX1, int recY1, int recX2, int recY2)
        {
            if ((pX == recX1 || pX == recX2) && pY >= recY1 && pY <= recY2) return "Border";
            else if ((pY == recY1 || pY == recY2) && pX >= recX1 && pX <= recX2) return "Border";
            else if (pX >= recX1 && pX <= recX2 && pY >= recY1 && pY <= recY2) return "Inside";
            else return ("Outside");
        }
    }
}
