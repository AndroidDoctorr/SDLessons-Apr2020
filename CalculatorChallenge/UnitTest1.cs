using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorChallenge
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calc = new Calculator();

        [TestMethod]
        public void AddTest()
        {
            double expected = 8;
            double actual = calc.Add(3, 5);
            Assert.AreEqual(expected, actual);

            Console.WriteLine(10/3);
        }

        [TestMethod]
        public void SubtractTest()
        {
            double expected = -2;
            double actual = calc.Sub(3, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MulTest()
        {
            double expected = -2;
            double actual = calc.Sub(3, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivTest()
        {
            string expected = "3 1/3";
            string actual = calc.Div(10, 3);
            Assert.AreEqual(expected, actual);
        }
    }
}
