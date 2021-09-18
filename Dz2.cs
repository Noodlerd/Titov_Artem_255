using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст до 100 лет : ");
            int n = int.Parse(Console.ReadLine());

            //лет 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 25 26 27 28 29 30
            //год 1 1 иск 11
            //года 2 3 4 2-4  искл 12 13 14

            if (n == 1 || n % 10 == 1 && n != 11)
            {
                Console.WriteLine($"Мне {n} год");
            }
            else if (n % 10 == 2 || n % 10 == 3 || n % 10 == 4 || n == 2 || n == 3 || n == 4 && n != 12 && n != 13 && n != 14)
            {
                Console.WriteLine($"Мне {n} года");
            }
            else
            {
                Console.WriteLine($"Мне {n} лет");
            }
        }
    }
}
