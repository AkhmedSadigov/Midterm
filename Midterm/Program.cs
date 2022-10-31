using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double p = 3.14;
                double r;

                Console.Write("Çevrenin sahesi: ");
                int sahe = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Çevrenin düsturu: p(r*r)");

                r = Math.Sqrt(sahe / p);

                Console.WriteLine("Çevrenin radiusu: " + r);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("\nZehmet olmasa duzgun ifade daxil edin!");
            }
            Console.ReadLine();
        }
    }
}
