using System;
using _08_Inheritance_Classes.Animals;
using _08_Inheritance_Classes.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Giraffe giraffe = new Giraffe();
            giraffe.Move();

            Wolf wolf = new Wolf();
            wolf.MakeSound();
            wolf.Move();

            Dog dog = new Dog();
            dog.MakeSound();
        }

        [TestMethod]
        public void PersonTest1()
        {
            Person person = new Person();
            person.SetFirstName("Summer");
            person.SetLastName("Kerekes");

            Console.WriteLine(person.Name);

            Employee employee = new Employee();
            employee.HireDate = new DateTime();
            employee.Email = "email@address.com";

            Console.WriteLine($"{employee.Name} ({employee.Email}) has been with the company for {employee.YearsWithCompany} years");
        }

        [TestMethod]
        public void StudentTest()
        {
            Student student = new Student();
            student.AverageScore = 95;
            Console.WriteLine(student.LetterGrade);
        }
    }
}
