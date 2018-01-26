using System;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            string top_bottom = "", left_right = "";

            for (int i = 0; i < size; i++)
            {
                top_bottom = top_bottom + "*";
            }

            if (size > 0)
            {
                left_right = "*";
                for (int i = 0; i < size - 2; i++)
                {
                    left_right = left_right + " ";
                }
                left_right = left_right + "*";
            }

            for (int i = 0; i < size; i++)
            {
                if (i == 0 || i == size - 1) Console.WriteLine(top_bottom);
                else Console.WriteLine(left_right);
            }


        }
    }
}