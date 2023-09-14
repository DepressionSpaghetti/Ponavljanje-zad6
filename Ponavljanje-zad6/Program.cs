using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3, suma = 0;
            int brojClanova;

            Console.WriteLine("Koliki je broj clanova reda");
            brojClanova = Convert.ToInt32(Console.ReadLine());

            for(int i = 0;i<brojClanova;i++)
            {
                suma += 1 / a;
                a *= 3;
            }

            Console.WriteLine(suma);


            Console.ReadKey();
        }
    }
}
