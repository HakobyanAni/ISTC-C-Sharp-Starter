using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Խնդիր_1:
            //Ներմուծել թիվ և հաշվել նրա թվանշանների գումարը:

            string s = Console.ReadLine();
            int number = Convert.ToInt32(s);
            int sumOfDigits = 0;
            while (number != 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }
            Console.WriteLine(sumOfDigits);
        }
    }
}
