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
            //Ներմուծել քառանիշ թիվ և հաշվել նրա թվանշանների գումարը:

            string s = Console.ReadLine();
            int number = Convert.ToInt32(s);
            int firstdigit = number / 1000;
            int seconddigit = number % 1000 / 100;
            int thirddigit = number % 100 / 10;
            int fourthdigit = number % 10;
            int sumofdigit = firstdigit + seconddigit + thirddigit + fourthdigit;
            Console.WriteLine(sumofdigit);
            Console.ReadKey();
        }
    }
}
