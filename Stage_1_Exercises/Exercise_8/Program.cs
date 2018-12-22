using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Խնդիր_8:
            // Տրված են A և B(A < B) ամբողջ թվերը։ Գտնել[A, B] հատվածին պատկանող 3-ին պատիկ առաջին թիվը։

            string stringA = Console.ReadLine();
            int A = Convert.ToInt32(stringA);
            string stringB = Console.ReadLine();
            int B = Convert.ToInt32(stringB);
            int div = 0;
            while (A <= B)
            {
                if (A % 3 == 0)
                {
                    div = A;
                    break;
                }
                A++;
            }
            Console.Write(div);
            Console.ReadKey();
        }
    }
}
