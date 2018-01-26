using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time=0;
            time += int.Parse(Console.ReadLine());
            time += int.Parse(Console.ReadLine());
            time += int.Parse(Console.ReadLine());

            Console.Write(time/60);
            Console.Write(":");

            if (time % 60 < 10) Console.Write("0");
            Console.Write(time % 60);
        }
    }
}
