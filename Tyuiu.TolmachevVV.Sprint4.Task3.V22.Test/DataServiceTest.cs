using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint4.Task3.V22.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(9, service1.Calculate(new int[,] { { 4, 4, 7, 8, 9 },
                                                               { 9, 5, 9, 7, 8 },
                                                               { 7, 4, 9, 4, 6 },
                                                               { 4, 4, 7, 4, 4 },
                                                               { 4, 5, 8, 6, 7 } }));
        }
    }
}
