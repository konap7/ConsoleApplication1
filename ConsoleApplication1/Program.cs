using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in tal 1: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nMata in tal 2: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            return Adddera(ta1, tal2);
        }

        static void Addera (int tal1, int tal2)
        {
            return tal1 + tal2;
        }
    }
}
