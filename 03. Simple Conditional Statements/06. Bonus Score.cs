using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {

            int inpt1 = int.Parse(Console.ReadLine());
            float endScore= 0.0f;

            if (inpt1 <= 100) endScore += 5;
            else if (inpt1 <= 1000) endScore += inpt1 * 0.2f;
            else endScore += inpt1 * 0.1f;

            if (inpt1 % 2 == 0) endScore++;
            if (inpt1 % 10 == 5) endScore += 2;

            Math.Round(endScore, 1);

            Console.WriteLine(endScore);
            Console.WriteLine(endScore+inpt1);


        }
    }
}
