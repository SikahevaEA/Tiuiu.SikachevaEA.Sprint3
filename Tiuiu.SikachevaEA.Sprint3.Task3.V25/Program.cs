using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint3.Task3.V25.Lib;
//Используя цикл foreach подсчитать минимальное количество букв u,
//находящихся на соседних позициях в строке: kjhgfuu gujut dtuu

namespace Tiuiu.SikachevaEA.Sprint3.Task3.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string value = "kjhgfuu gujut dtuu";
            char chr = 'u';

            Console.WriteLine("исходная строка = " + value);
            Console.WriteLine("исходный символ = " + chr);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Минимальное количество символов =  " + ds.GetMinCharCount(value, chr));
            Console.ReadKey();
        }
    }
}
