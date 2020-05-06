using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Vehicle vehicleOne = new Vehicle();
            vehicleOne.Make = "Ford";
            Console.WriteLine(vehicleOne.Make);
            Console.WriteLine(vehicleOne.Model);

            Console.WriteLine("\n\n");

            Vehicle vehicleTwo = new Vehicle("Dodge", "Journey", 200000.0, VehicleType.SUV);

            Console.WriteLine(vehicleTwo.Make);
        }

        [TestMethod]
        public void PersonTest()
        {
            Person someone = new Person();
            someone.FirstName = "Andrew";
            someone.LastName = "Torr";
            // someone.FullName = "asfdgfd"; <- NO
            Console.WriteLine(someone.FirstName);
            Console.WriteLine(someone.LastName);
            Console.WriteLine(someone.FullName);

            Person someoneElse = new Person();
            someoneElse.DateOfBirth = new DateTime(1985, 9, 22);

            someone.DateOfBirth = DateTime.Now;

            Console.WriteLine(someoneElse.Age);
            Console.WriteLine(someone.Age);

            Vehicle myCar = new Vehicle("Dodge", "Journey", 200000.0, VehicleType.SUV);
            someone.Transport = myCar;

            Console.WriteLine(someone.Transport.Make);
        }


        [TestMethod]
        public void UserTest()
        {
            User user = new User("someaddress@internet.com", "anonymous");

            Console.WriteLine(user.Email);
            Console.WriteLine(user.UserName);
            Console.WriteLine(user.ID);
            Console.WriteLine(user.JoinDate);

            User otherUser = new User("someaddress@internet.com", "anonymous");

            Console.WriteLine(otherUser.Email);
            Console.WriteLine(otherUser.UserName);
            Console.WriteLine(otherUser.ID);
            Console.WriteLine(otherUser.JoinDate);
        }
    }
}
