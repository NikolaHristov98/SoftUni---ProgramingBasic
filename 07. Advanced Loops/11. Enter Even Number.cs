using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace _14.try_catch

{

    class Program

    {

        static void Main(string[] args)

        {

            int inpt;



            while (true)

            {

                try

                {

                    inpt = int.Parse(Console.ReadLine());

                    if (inpt % 2 == 0)

                    {

                        Console.WriteLine("Even nuber entered: {0}", inpt);

                        break;

                    }

                    else Console.WriteLine("The number is not even.");

                }

                catch (Exception)

                {

                    Console.WriteLine("Invalid number");



                }



            }

        }

    }

}

