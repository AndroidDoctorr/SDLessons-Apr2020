using _09_Interfaces.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;

        private void PayDebt(ICurrency payment)
        {
            _debt -= payment.Value;
            Console.WriteLine($"You have paid ${payment.Value} towards your debt.");
        }

        [TestInitialize]
        public void Arrange()
        {
            _debt = 9000.01m;
        }

        [TestMethod]
        public void PayDebtTest()
        {
            PayDebt(new Dollar());
            PayDebt(new ElectronicPayment(123.45m));

            decimal expectedDebt = (decimal) 9000.01 - (decimal) 124.45;

            Assert.AreEqual(expectedDebt, _debt);
        }
    }
}
