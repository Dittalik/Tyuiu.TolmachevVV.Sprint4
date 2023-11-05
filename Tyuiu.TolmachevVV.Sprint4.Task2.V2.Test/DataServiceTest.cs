using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint4.Task2.V2.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CaclCheck()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(1323, service1.Calculate(new int[] { 7, 7, 8, 8, 2, 6, 3, 3, 3, 1 }));
        }
    }
}
