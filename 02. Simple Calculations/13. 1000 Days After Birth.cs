using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_days_after_birth
{
    class Program
    {
        static void Main(string[] args)
        {

            string date ;
            DateTime birth = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            birth=birth.AddDays(999);
            date = birth.ToString("dd-MM-yyyy");
            Console.WriteLine(date);
        }
    }
}
