using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Խնդիր_9:
            // Տրված է N բնական թիվը։ Հաշվել 1 + 1 / 2 + 1 / 3 + … +1 / N գումարը(այն իրական թիվ է)։

            string s = Console.ReadLine();
            double N = Convert.ToDouble(s);
            double N_sm = 1.0;
            for (int i = 2; i <= N; i++)
            {
                N_sm += ((double)(1) / i);
            }
            Console.WriteLine(N_sm);
            Console.ReadKey();
        }
    }
}
