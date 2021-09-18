using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 1000;

            for (int i = 0; i < 120000; i++)
            {
                if ((value % 133 == 125) && (value % 134 == 111))
                {
                    Console.WriteLine($"Данное число  удовлетворяет условиям : " + value);
                }
                value++;
            }
        }
    }
}
