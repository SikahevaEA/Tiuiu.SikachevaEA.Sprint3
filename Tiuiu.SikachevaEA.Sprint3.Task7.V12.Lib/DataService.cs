using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tiuiu.SikachevaEA.Sprint3.Task7.V12.Lib
{
    public class DataService : ISprint3Task7V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (3 * x + 0.5 == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    y = Math.Round((Math.Sin(x) + 2 / (3 * x + 0.5) - 2 * Math.Cos(x) * 2 * x), 2);
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
        }
    }
}
