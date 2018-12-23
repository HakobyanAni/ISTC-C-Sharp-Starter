using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Խնդիր_10:
            // Տրված է N բնական թիվը։ Հաշվել N2 +(N + 1)2 + (N + 2)2 + … +(2·N)2 գումարը։
            string @string = Console.ReadLine();
            int number = Convert.ToInt32(@string);
            int progres = 3 * number * (number + 1);
            Console.WriteLine(progres);
            Console.ReadKey();
        }
    }
}
