using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string isLeap = Console.ReadLine();
            double p = double.Parse(Console.ReadLine()),
                h = double.Parse(Console.ReadLine());

            double sum = (48-h) * 3 / 4 + h + p * 2 / 3;
            if (isLeap == "leap") sum += sum * 15/100;
            sum = Math.Floor(sum);

            Console.WriteLine(sum);


        }
    }
}
