using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Խնդիր_2:
            //Տրված են K և N(N > 0) ամբողջ թվերը։ N անգամ արտածել K թիվը։

            string s1 = Console.ReadLine();
            int K = Int32.Parse(s1);
            string s2 = Console.ReadLine();
            int N = Int32.Parse(s2);
            for (int i = 0; i < N; i++)
            {
                Console.Write(K + "\0");
            }
            Console.ReadKey();
        }
    }
}
