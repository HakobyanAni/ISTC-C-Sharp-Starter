using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Խնդիր_6:
            //Տրված են A և B(A < B) ամբողջ թվերը։ Արտածել աճման կարգով[A, B] հատվածին պատկանող 
            //ամբողջ թվերը, ապա նաև նրանց քանակը։

            string numb1 = Console.ReadLine();
            int A = Int32.Parse(numb1);
            string numb2 = Console.ReadLine();
            int B = Int32.Parse(numb2);
            int counter = 0;
            while (A <= B)
            {
                Console.Write(A + "\0");
                ++counter;
                A++;
            }
            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
