using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint4.Task1.V26.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(24, service1.Calculate(new int[] { 7, 7, 8, 8, 2, 6, 3, 3, 3, 1 }));
        }
    }
}
