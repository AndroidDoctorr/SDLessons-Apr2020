using System;
using System.Collections.Generic;
using _09_Interfaces.Currency;
using _09_Interfaces.Fruits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<IFruit> fruitSalad = new List<IFruit>();
            Orange orange = new Orange();
            Banana banana = new Banana();
            fruitSalad.Add(orange);
            fruitSalad.Add(banana);

            foreach (IFruit fruit in fruitSalad)
            {
                fruit.Peel();
            }
        }

        [TestMethod]
        public void CurrencyTest1()
        {
            ElectronicPayment ePayment = new ElectronicPayment(3.50m);
            Console.WriteLine(ePayment.Value);

            Dollar dollar = new Dollar();
            Assert.AreEqual(dollar.Value, 1.0m);
        }
    }
}
