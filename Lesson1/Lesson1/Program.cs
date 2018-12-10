using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Tree
    {
        public int Height { get; set; }

        public void Oror(bool qami)
        {
            if(qami)
                Console.WriteLine("es ororvum em");
            else
            {
                Console.WriteLine("es chem ororvum");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tree car1 = new Tree();
            car1.Height = 10;

            Tree car2 = car1;

            car2.Height = 20;

            //car1.Oror(true);
            //car2.Oror(false);

            Console.WriteLine(car1.Height);
            Console.WriteLine(car2.Height);


            Console.ReadKey();

        }
    }
}
