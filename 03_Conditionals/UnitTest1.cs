using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Conditionals
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = false;
            int someNum = 3;
            if (userIsHungry)
            {
                Console.WriteLine("Eat something!!");
            }
            else if (someNum == 3)
            {
                Console.WriteLine("It is three!");
            }
            else
            {
                Console.WriteLine("What did you eat?");
            }

            Console.WriteLine("I am " + (userIsHungry ? "" : "not ") + "hungry");


            string input = "6";
            // int totalHours = Convert.ToInt32(input);
            int totalHours = int.Parse(input);

            if (totalHours >= 7)
            {
                Console.WriteLine("You should be well rested");
            }
            else if (totalHours < 3)
            {
                Console.WriteLine("How are you keeping your eyes open??");
            }
            else
            {
                Console.WriteLine("You could use a little more sleep");
            }


        }

        enum WeekDay { Mon, Tue, Wed, Thu, Fri, Sat, Sun };

        [TestMethod]
        public void SwitchCase()
        {
            WeekDay today = WeekDay.Tue;

            switch (today)
            {
                case WeekDay.Mon:
                    Console.WriteLine("It's Monday!");
                    break;
                case WeekDay.Tue:
                case WeekDay.Wed:
                case WeekDay.Thu:
                case WeekDay.Fri:
                    Console.WriteLine("Just another work day");
                    break;
                case WeekDay.Sat:
                case WeekDay.Sun:
                    Console.WriteLine("Woohoo! Weekend!");
                    break;
            }
        }
    }
}
