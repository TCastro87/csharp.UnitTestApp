﻿using System;
using BasicMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicMathTDDTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Add(20.50, 20.50);
            Assert.AreEqual(41, res);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(100, res);
        }
    }
}



//https://www.c-sharpcorner.com/article/a-basic-introduction-of-unit-test-for-beginners/