using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;

            Console.Write("Upisite jedan broj: ");
            broj = Convert.ToInt32(Console.ReadLine());

            if (broj % 4 == 0 && broj%6 !=0)
            {
                Console.WriteLine("Broj je djeljiv s 4");
            }
            if (broj % 6 == 0 && broj%4 !=0)
            {
                Console.WriteLine("Broj je djeljiv s 6");
            }
            if (broj % 4 == 0 && broj % 6 == 0)
            { Console.WriteLine("Broj je djeljiv sa 4 i sa 6"); 
            }
            if (broj % 4 != 0 && broj % 6 != 0)
            {
                Console.WriteLine("Broj nije dijeljiv s 4 i 6 ");
            }

            Console.ReadKey();
        }
    }
}
