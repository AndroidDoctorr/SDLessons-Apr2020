using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Loops
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhileLoops()
        {
            int counter = 1;
            while (counter <= 100)
            {
                Console.WriteLine(counter);
                // counter = counter + 1;
                counter += 2;
                // counter++;
            }
            Console.WriteLine("Done!");

            int someNum = 50;
            bool isDivisibleByThirteen = false;
            while (!isDivisibleByThirteen)
            {
                isDivisibleByThirteen = (someNum % 13) == 0;
                Console.WriteLine(someNum);
                someNum += 2;
            }

            bool neverTrue = false;
            while (neverTrue)
            {
                Console.WriteLine("This will never happen");
            }

            int iterator = 0;
            do
            {
                Console.WriteLine("hello");
                iterator++;
            }
            while (iterator == 5);
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 18;
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Michael", "Robert", "Seth", "Summer", "Alex", "Kevin" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i][0]);
            }
        }


        [TestMethod]
        public void FoeachLoops()
        {
            string[] students = { "Michael", "Robert", "Seth", "Summer", "Alex", "Kevin" };

            foreach (string student in students)
            {
                Console.WriteLine($"{student} is a student in this class");
            }

            string name = "Andrew Torr";
            foreach (char letter in name)
            {
                if (letter != ' ' && letter != 'e') // Use one operator at a time
                {
                    Console.WriteLine(letter);
                }
            }

            // Console.WriteLine('dsfagfdgd'); ERROR
            Console.WriteLine("p");
            char dsgfs = (char) 7;


            int number = 5;
            Console.WriteLine(++number);
            Console.WriteLine(number);
        }
    }
}
