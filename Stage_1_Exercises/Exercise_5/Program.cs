using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        //Խնդիր_5:
        //Հաշվել տրված բնական թվին չգերազանցող զույգ թվերի գումարը՝ առանց զույգությունը ստուգելու։
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int numb = Int32.Parse(s);
            int sumOfNumber = 0;
            for (int i = 2; i <= numb; i += 2)
            {
                sumOfNumber += i;
            }
            Console.WriteLine(sumOfNumber);
            Console.ReadKey();
        }
    }
}
