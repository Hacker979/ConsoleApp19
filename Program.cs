using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void AP(int a1, double d)
        {
            double t = 0;
            for (int i = 0; i < 150; i++)
            {              
                t += a1 + i * d;
            }
            Console.WriteLine($"sum = {t}");
        }
        /// <summary>
        /// Задача 4. Составьте программу вычисления суммы 150 первых членов арифметической прогрессии, если a1= –200; d = 0,2.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            AP(-200, 0.2);

            Console.ReadLine();
        }
    }
}
