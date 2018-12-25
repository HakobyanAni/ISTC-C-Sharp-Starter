using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Խնդիր_11:
            // Տրված է N բնական թիվը։ Հաշվել 1.1 · 1.2 · 1.3 · … արտադրյալը(արտադրիչների քանակը N է)։
            string s = Console.ReadLine();
            double number = Convert.ToDouble(s);
            double mult = 1;
            double part = 1.1;
            for (int i = 0; i < number; i++)
            {
                mult *= part;
                part += 0.1;
            }
            Console.WriteLine(mult);
            Console.ReadKey();
        }
    }
}
