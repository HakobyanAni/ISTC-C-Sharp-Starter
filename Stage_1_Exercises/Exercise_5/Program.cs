using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Խնդիր_3:
            // Ներածել n միանիշ թիվը։ Արտածել n-ին չգերազանցող թվանշանները։
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            while (n >= 0)
            {
                Console.Write(n + "\0");
                n--;
            }
            Console.ReadKey();
        }
    }
}
