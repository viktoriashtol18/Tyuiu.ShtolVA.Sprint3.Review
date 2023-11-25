using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtolVA.Sprint3.TaskReview.V16.Lib;

namespace Tyuiu.ShtolVA.Sprint3.TaskReview.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int startValue = -1;
            int stopValue = 1;
            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 8.35;
            valueWaitArray[1] = -0.50;
            valueWaitArray[2] = 9.63;
            

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
