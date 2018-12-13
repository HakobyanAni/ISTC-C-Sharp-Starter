using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Խնդիր_7:
            // Տրված են A և B(A < B) ամբողջ թվերը։ Գտնել[A, B] հատվածին պատկանող բոլոր ամբողջ թվերի գումարը։
                       
            string numbA = Console.ReadLine();
            int A = Int32.Parse(numbA);
            string numbB = Console.ReadLine();
            int B = Int32.Parse(numbB);
            int sum = 0;
            while (A <= B)
            {
                sum += A;
                A++;
            }
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}
