using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint4.Task0.V14.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SumCheck()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(30, service1.GetSumOddArrEl(new int[] { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 }));
        }
    }
}
