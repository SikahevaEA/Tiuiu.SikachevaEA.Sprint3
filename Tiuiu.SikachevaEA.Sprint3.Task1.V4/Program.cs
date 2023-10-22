using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint3.Task1.V4.Lib;
//Написать программу используя цикл while, которая вычисляет сумму ряда по формуле
//
//     10
//     ___   ( 1 )^2
// S=  \     (---)
//     /__   ( k )
//     k = 1
//


namespace Tiuiu.SikachevaEA.Sprint3.Task1.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int startValue = 1;
            int stopValue = 14;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма равна = " + ds.GetSumSeries(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
