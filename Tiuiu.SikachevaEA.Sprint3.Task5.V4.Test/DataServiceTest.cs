using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint3.Task5.V4.Lib;

namespace Tiuiu.SikachevaEA.Sprint3.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 13;

            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);

            double wait = 1112.156;

            Assert.AreEqual(wait, res);
        }
    }
}
