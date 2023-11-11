using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint4.Task5.V28.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            CollectionAssert.AreEqual(new int[,] { { 0, 0 }, { 0, 0 } }, service1.Calculate(new int[,] { { -2, -2 }, { -2, -2 } }));
        }
    }
}
