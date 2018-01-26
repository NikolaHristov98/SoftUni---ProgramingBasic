using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double BitCoins = double.Parse(Console.ReadLine()),
                   CHN = double.Parse(Console.ReadLine()),
                   Commission = double.Parse(Console.ReadLine());

            double BGN = BitCoins * 1168 + CHN * 0.15f * 1.76f;
            double EUR = BGN / 1.95f;
            EUR = EUR - (EUR * Commission/100);
            Console.WriteLine("{0:F2}",EUR);

        }
    }
}
