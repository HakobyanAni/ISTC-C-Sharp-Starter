using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Խնդիր_12:
            // Ներածել n թիվը։ Արտածել yes, եթե այն հավասար է իր թվանշանների գումարի կրկնապատիկին, no՝ հակառակ դեպքում։

            string s = Console.ReadLine();
            int number = Convert.ToInt32(s);
            int n = number;
            int sumOfDigits = 0;
            while (number != 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }

            Console.WriteLine((sumOfDigits * 2 == n) ? "yes" : "no");
            Console.ReadKey();
        }
    }
}
