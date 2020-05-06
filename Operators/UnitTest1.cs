using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Operators
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Operators()
        {
            int a = 22;
            int b = 15;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine((double) a / b);
            Console.WriteLine(a % b); // Modulo

            // Console.WriteLine(b % 2 == 1 ? "odd" : "even");

            DateTime now = DateTime.Now;
            DateTime birthDay = new DateTime(1985, 9, 22, 21, 3, 0);

            TimeSpan timeSpan = now - birthDay;
            double age = timeSpan.TotalDays / 365.24;
            Console.WriteLine(age);
        }

        [TestMethod]
        public void Comparisons()
        {
            string name = "Andrew";
            int age = 34;

            Console.WriteLine(name == "Adam");
            Console.WriteLine(age >= 34);
            Console.WriteLine("Am I an adult? " + (age > 18));
            Console.WriteLine("Am I not 64? " + (age != 64));

            bool trueValue = true;
            bool falseValue = false;

            Console.WriteLine(trueValue || falseValue); // OR
            Console.WriteLine(trueValue && falseValue); // AND
            Console.WriteLine(trueValue && (trueValue || falseValue) && !falseValue);


        }
    }
}
