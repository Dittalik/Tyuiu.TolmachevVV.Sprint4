using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint4.Task6.V2.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            CollectionAssert.AreEqual(new string[] { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" }, service1.Calculate(new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" }));
        }
    }
}
