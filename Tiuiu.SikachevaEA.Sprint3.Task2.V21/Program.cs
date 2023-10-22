using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint3.Task2.V21.Lib;
//Написать программу используя цикл do...while, которая вычисляет сумму ряда по формуле, при х=1,5
//
//     10
//     ___   (       1      )^k
// S=  \     (--------------)
//     /__   ( sin(k) + 2x^k)
//     k = 1
//

namespace Tiuiu.SikachevaEA.Sprint3.Task2.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double value = 1.5;
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
