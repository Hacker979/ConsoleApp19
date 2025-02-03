using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void P(double startDist, double maxDist, double totalDist, double g)
        {
            double d = startDist, s = startDist;
            int p1 = 1;
            int p2 = 1;

            while (d <= maxDist || s <= totalDist)
            {
                p1 = (d <= maxDist) ? p1 + 1 : p1;
                p2 = (s <= totalDist) ? p2 + 1 : p2;

                d *= g;
                s += d;
            }
            Console.WriteLine($"В день {p1} лыжник пробежит больше 20 км.");
            Console.WriteLine($"Суммарный пробег превысит 100 км на день {p2}.");
        }
        /// <summary>
        /// Задача 5. Начав тренировки, лыжник в первый день пробежал 10 км. Каждый следующий день он увеличивал пробег на 10% от пробега предыдущего дня. Определить:
        /// а) в какой день он пробежит больше 20 км;
        /// б) в какой день суммарный пробег за все дни превысит 100 км.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            P(10, 20, 100, 1.1);

            Console.ReadLine();
        }
    }
}
