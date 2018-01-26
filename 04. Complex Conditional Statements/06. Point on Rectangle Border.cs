using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] points = new float[6];

            for (int i = 0; i < 6; i++)
            {
                points[i] = float.Parse(Console.ReadLine());
            }

                if ((points[4] == points[0] || points[4] == points[2]) && points[5] >= points[1] && points[5] <= points[3]) Console.WriteLine("Border");
                else if ((points[5] == points[1] || points[5] == points[3]) && points[4] >= points[0] && points[4] <= points[2]) Console.WriteLine("Border");
                else Console.WriteLine("Inside / Outside");
        }
    }
}