using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class UnitTest1
    {
        // 1. Access Modifier   (public, private, etc)
        // 2. Return Type   (a type value the method puts out)
        // 3. Method signature   (3.1 - Name   3.2 - Parameters)
        // 4. Body (the part that is executed)

        // 1   //2  //3.1   //3.2
        public void SayHello(string name)
        {
            //4
            // string name = "Andrew";
            Console.WriteLine($"Hello, {name}");
        }

        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        public int Add(int numOne, int numTwo, int numThree)
        {
            int sum = numOne + numTwo + numThree;
            return sum;
        }

        public int AddAll(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        private int CalculateAge(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAge = ageSpan.TotalDays / 365.24;

            int years = Convert.ToInt32(Math.Floor(totalAge));

            // Floor:  3.94159265358979432383279 => 3
            // Ceil: 3.0001675475675643 => 4

            return years;
        }



        // Annotation
        [TestMethod]
        public void TestMethod1()
        {
            SayHello("Andrew");
            SayHello("Adam");
        }

        [TestMethod]
        public void MyTestMethod()
        {
            SayHello("Summer");

            int sum = Add(3, 8);
            Console.WriteLine(sum);
            int otherSum = Add(4, 7);
            Console.WriteLine(otherSum);

            Console.WriteLine("Three: " + Add(1,2));

            Console.WriteLine("a double: " + Add(5.3, 7.1));

            Console.WriteLine("Three numbers: " + Add(9, 5, -4));

            int[] numArray = { 1, 2, 3 };
            Console.WriteLine(AddAll(numArray));

            Console.WriteLine($"I am {CalculateAge(new DateTime(1985, 9, 22))} years old");

            DateTime AdamsBirthday = new DateTime(1991, 10, 4);
            Console.WriteLine($"Adam is {CalculateAge(AdamsBirthday)} years old");
        }


        [TestMethod]
        public void MaryPoppins()
        {
            string word = "  supercalifragilisticexp'][,.3#$%^&$ialidocious435675785673546 \" \\   \n\n\t\t";
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }
            Console.WriteLine("\n\n\n");
            Console.WriteLine(word.Count(char.IsWhiteSpace));
            Console.WriteLine(word.Length);
            Console.WriteLine("\n\n\n");

            foreach (char letter in word)
            {
                if (letter == 'i' || letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an \"i\"");
                }
                count++;
            }
            // Console.WriteLine($"letters: {word.Length}");
            Console.WriteLine($"letters: {count}");


            string number = "6";
            int actualNumber = Convert.ToInt32(number);

            int anotherNumber = int.Parse(number);

            int result;
            // int yetAnotherNumber = int.TryParse(number, out result);

            bool isANumber = int.TryParse(number, out result);
            int yetAnotherNumber;
            if (isANumber)
            {
                yetAnotherNumber = result;
            } else
            {
                yetAnotherNumber = 0;
            }
        }
    }
}
