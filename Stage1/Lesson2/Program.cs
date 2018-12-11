using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Exercise_1
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int number = Convert.ToInt32(s);
            int first_digit = number / 1000;
            int second_digit = number % 1000 / 100;
            int third_digit = number % 100 / 10;
            int fourth_digit = number % 10;
            int sum_of_digit = first_digit + second_digit + third_digit + fourth_digit;
            Console.WriteLine(sum_of_digit);
        }
    }
}
