using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s4 = Console.ReadLine();
            int Num = Convert.ToInt32(s4);
            Console.WriteLine("{0} pow 1 = {1}", Num, Num);
            for (int i = 2; i < 10; i++)
            {
                int N_num = Num;
                for (int j = 1; j < i; j++)
                {
                    N_num *= Num;
                }
                Console.WriteLine("{0} pow {1} = {2}", Num, i, N_num);
            }
            Console.ReadKey();
        }
    }
}
