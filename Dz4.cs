using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 500;


            for (int i = 0; i < 20;)
            {
                if (value % 13 == 0 || value % 17 == 0)
                {
                    Console.WriteLine($"Данное число  удовлетворяет условиям: " + value);
                    i++;
                }
                value++;
            }
        }
    }
}
