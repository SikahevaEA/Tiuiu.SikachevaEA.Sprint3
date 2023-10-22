using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tiuiu.SikachevaEA.Sprint3.Task1.V4.Lib
{
    public class DataService : ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double SumSeries = 1;
            while (startValue <= stopValue)
            {
                SumSeries = SumSeries + (Math.Pow((1 / startValue), 2));
                startValue++;
            }
            return Math.Round(SumSeries, 3);
        }
    }
}
