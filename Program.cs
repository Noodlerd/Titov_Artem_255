using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            int value = int.Parse(Console.ReadLine());

            if (value % 2 == 0)
            {
                Console.Write($"Число {value} является чётным");
            }
            else
            {
                Console.Write($"Число {value} является нечётным");
            }

            if (value % 10 == 7)
            {
                Console.WriteLine($" и заканчиваеться на 7");
            }
        }
    }
}
