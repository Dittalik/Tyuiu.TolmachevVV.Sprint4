﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint4.Task4.V6.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] check = { { 0, 6, 6, 6, 0 },
                             { 4, 4, 4, 0, 4 },
                             { 0, 0, 0, 6, 0 },
                             { 4, 0, 0, 0, 0 },
                             { 6, 0, 0, 6, 0 } };
            DataService service1 = new DataService();
            CollectionAssert.AreEqual(check ,service1.Calculate(new int[,] { { 7, 6, 6, 6, 9 },
                                                                             { 4, 4, 4, 9, 4 },
                                                                             { 5, 5, 5, 6, 5 },
                                                                             { 4, 9, 5, 9, 7 },
                                                                             { 6, 9, 5, 6, 7 } }));
        }
    }
}
