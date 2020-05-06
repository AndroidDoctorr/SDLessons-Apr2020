using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SDLessonsA
{
    enum PastryType { Cake, Cupcake, Eclaire = 50, Donut, Croissant };

    enum BadgeType { Whtie, Gold, Blue, Red };

    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void StringTest()
        {
            string thisIsDeclaration;

            string greeting = "good morning";
            int one = 1;

            double something = 5.3;

            int somethingElse = (int) Math.Round(one * something);

            // Console.WriteLine(thisIsDeclaration);

            Console.WriteLine(greeting);

            string firstName = "Andrew";
            string lastName = "Torr";

            Console.WriteLine(firstName + lastName); // Concatenate

            Console.WriteLine($"Hello, {something * 8.1} {lastName}"); // Interpolate

            Console.WriteLine($"Hello, {something * 8.1, -15} {lastName, -15}  {"sdfgdh",-15}"); // Interpolate + formatting

            Console.WriteLine($"Hello, {something * 23.6,-15} {firstName,-15}  {"sgdhjydsdsrhh",-15}"); // Interpolate + formatting

            Console.WriteLine("{0} blah {1}", firstName, lastName); // Composite
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World!";
            string[] stringArray = { "Hello", "world", "why", "is it", "always", stringExample, "?" };

            Console.WriteLine(stringArray[0]);

            List<string> listOfStrings = new List<string>();

            listOfStrings.Add("hello");
            listOfStrings.Add("potato");
            Console.WriteLine(listOfStrings.Count);

            List<int> listOfInts = new List<int>() {
                1,
                2,
                23457689,
            };

            listOfInts.RemoveAt(1);
            Console.WriteLine(listOfInts[1]);

            Queue<string> firstInFirstOut = new Queue<string>();

            firstInFirstOut.Enqueue("ME FIRST!");
            firstInFirstOut.Enqueue("I'm next!");

            string firstItem = firstInFirstOut.Dequeue();

            Console.WriteLine(firstItem);

            Dictionary<string, int> keysAndValues = new Dictionary<string, int>()
            {
                { "something", 3 },
                { "aNumber", 3 },
            };

            keysAndValues.Add("key", 3);
            keysAndValues.Remove("key");
            keysAndValues.Add("key", 3);

            Console.WriteLine(keysAndValues["key"]);

            Dictionary<int, string> newDictionary = new Dictionary<int, string>();

            newDictionary.Add(5, "Five");

            // Not covering these, you can look them up if you want extra practice
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }

        [TestMethod]
        public void Classes()
        {
            DateTime date = new DateTime(1990, 04, 28);

            DateTime now = DateTime.Now;

            Random rand = new Random();

            int randomNumber = rand.Next();
            Console.WriteLine(randomNumber);

            int anotherRandom = rand.Next(0, 6) + 1;
            Console.WriteLine(anotherRandom);
        }

        [TestMethod]
        public void Types()
        {
            bool isDeclared; // Declare

            isDeclared = true; // Initialize

            bool isDeclaredAndInitialized = false;


            char character = 'a';
            char anotherChar = '9';
            string someString = "3456";
            char secondChar = someString[1];


            char space = ' ';
            // char tab = '\t';
            char newLine = '\n';

            Console.WriteLine("hello\n\n\nworld");
            Console.Write("sfdg");

            // Console.Write("aaaaa\n");      is the same as       Console.WriteLine("aaaaa"); 

            // CR = Carriage Return
            // LF = Line Feed


            byte byteExample = 255;
            // sbyte

            short shortExample = 234;
            // int
            // Int16 Int32 Int64
            long longExample = 214357687543214256;


            float floatExample = 1.2345768996543f;

            Console.WriteLine(1.257890728904578978978978435643257684359787897f);
            Console.WriteLine(1.257890728904578978978978435643257684359787897d);
            Console.WriteLine(1.257890728904578978978978435643257684359787897m);
        }

        [TestMethod]
        public void Enums()
        {
            PastryType pastryType = PastryType.Cake;
            PastryType anotherOne = PastryType.Croissant;

            Console.WriteLine((int) anotherOne);
        }
    }
}
