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
            //Խնդիր_4:
            //Ներածել n բնական թիվը։ Արտածել n–ի 1–ից մինչև 9 աստիճանների արժեքները։

            string s4 = Console.ReadLine();
            int Num = Convert.ToInt32(s4);
            Console.WriteLine("{0} pow 1 = {1}", Num, Num);
            for (int i = 2; i < 10; i++)
            {
                int N = Num;
                for (int j = 1; j < i; j++)
                {
                    N *= Num;
                }
                Console.WriteLine("{0} pow {1} = {2}", Num, i, N);
            }
            Console.ReadKey();
        }
    }
}
