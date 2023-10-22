using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint3.Task0.V25.Lib;
//Написать программу используя цикл for, которая вычисляет сумму ряда по формуле, при X=5
//
//     14
//     ___   (   4   )^i
// S=  \     (-------)
//     /__   (1 + x^i)
//     i = 1
//

namespace Tiuiu.SikachevaEA.Sprint3.Task0.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int value = 5;
            int startValue = 1;
            int stopValue = 14;

            Console.WriteLine("Переменная х = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма равна = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
