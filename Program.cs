using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void AP(int a1, int d)
        {
            int t = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(a1 + i * d + " ");
                
                t += a1 + i * d;
            }
            Console.WriteLine($"sum = {t}");
        }
        /// <summary>
        /// Задача 2. Вывести первые пять членов арифметической прогрессии (с использованием цикла) и найти их общую сумму,
        /// если a1=1, d=4 (например, 1  5  9  13  17, sum=45).        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            AP(1, 4);

            Console.ReadLine();
        }
    }
}
