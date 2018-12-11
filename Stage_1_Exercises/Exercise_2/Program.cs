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
