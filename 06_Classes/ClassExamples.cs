using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    public enum VehicleType { Car, Truck, Van, SUV, Motorcycle, Hovercraft, Spaceship }
    public class Vehicle
    {
        public string Make { get; set; } = "None";
        public string Model { get; set; }
        public double Mileage { get; set; } = 0;
        public VehicleType TypeOfVehicle { get; set; }


       
        
        public Vehicle()
        {
            Console.WriteLine("Vehicle created!");
        }
        

        public Vehicle(string make, string model, double mileage, VehicleType type)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = type;
        }
    }

    public class Person
    {
        // Property
        public string FirstName { get; set; } // Shorthand for getter and setter

        // public string LastName { get; set; }


        // Backing Field
        private string _lastName;
        // Property
        public string LastName
        {
            get { return _lastName.ToUpper(); }  // Actual getter method
            set {
                string newName = value + "fff";
                _lastName = newName;
            }  // Actual setter method
        }

        // public void SetLastName(string value)
        // {
        //     _lastName = value;
        // }

        public string FullName
        {
            get
            {
                return $"{FirstName} {_lastName}";
            }
        }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.24;
                int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return years;
            }
        }

        public Vehicle Transport { get; set; }
    }

    public class User
    {
        public int ID { get; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime JoinDate { get; }

        // Blank Constructor (do not use in this case...)
        public User() { }

        public User(string email, string userName)
        {
            Random rand = new Random();
            int id = rand.Next(0, 999999999);
            ID = id;

            Email = email;
            UserName = userName;

            JoinDate = DateTime.Now;
        }

        // thisIsCalledCamelCase
        // ThisIsCalledPascalCase
        // this-is-kebab-case
        // this_is_snaaaaaaake_case
    }
}
