using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tiuiu.SikachevaEA.Sprint3.Task0.V25.Lib
{
    public class DataService : ISprint3Task0V25
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            int sumSeries = 0;
            double sumSeries1 = Convert.ToDouble(sumSeries);
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries1 = sumSeries1 + (Math.Pow((4 / (1 + Math.Pow(value, 1))), 1));
            }
            return Math.Round(sumSeries1, 3);
        }
    }
}
