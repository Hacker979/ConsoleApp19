using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void D(int a, int b, int m)
        {
            int total = 0;
            for (int i = 0; i < m; i++)
            {
                total += a + i * b;
            }
            Console.WriteLine("Сумма через 10 месяцев: " + total);
        }
        /// <summary>
        /// Задача 3. Родители ко дню рождения своего сына Андрея решили купить и обновить ему мобильный телефон.
        /// Для этого они в первый месяц отложили 100 руб., а в каждый последующий на 50 рублей больше.
        /// Какая сумма будет через десять месяцев? 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            D(100, 50, 10);

            Console.ReadLine();
        }
    }
}
