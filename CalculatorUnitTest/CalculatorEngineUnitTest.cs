﻿using System;
using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorEngineUnitTest
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            //
            int a = 1;
            int b = 2;
            int expected = 3;

            //
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Add(a, b);

            //Comparaison avec le resulat et la fonction
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodSub()
        {
            //
            int a = 4;
            int b = 2;
            int expected = 2;

            //
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Sub(a, b);

            //Comparaison avec le resulat et la fonction
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodMul()
        {
            //
            int a = 3;
            int b = 2;
            int expected = 6;

            //
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Mul(a, b);

            //Comparaison avec le resulat et la fonction
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodDiv()
        {
            //
            int a = 4;
            int b = 2;
            int expected = 2;

            //
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Div(a, b);

            //Comparaison avec le resulat et la fonction
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        public void TestMethodDivByZero()
        {
            //
            int a = 6;
            int b = 0;
            int expected = Int32.MinValue;

            //
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Div(a, b);

            //Comparaison avec le resulat et la fonction
            Assert.AreEqual(expected, actual);
        }
    }
}
