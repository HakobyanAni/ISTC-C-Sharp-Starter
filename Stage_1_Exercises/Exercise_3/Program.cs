using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s3 = Console.ReadLine();
            int n = Convert.ToInt32(s3);
            while (n >= 0)
            {
                Console.Write(n + "\0");
                n--;
            }
            Console.ReadKey();
        }
    }
}
