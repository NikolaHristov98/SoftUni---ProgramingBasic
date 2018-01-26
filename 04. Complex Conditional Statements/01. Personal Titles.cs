using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            float age = float.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            if (age < 16)
            {
                if (gender == 'm') Console.WriteLine("Master");
                else Console.WriteLine("Miss");
            }
            else
            {
                if (gender == 'm') Console.WriteLine("Mr.");
                else Console.WriteLine("Ms.");
            }
        }
    }
}
