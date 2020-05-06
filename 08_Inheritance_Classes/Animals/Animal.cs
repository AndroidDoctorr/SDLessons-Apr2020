using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.Animals
{
    public enum DietType { Herbivore, Carnivore, Omnivore }
    public abstract class Animal
    {
        public string Color { get; set; }
        public bool HasTail { get; set; } = false;
        public int NumberOfLegs { get; set; }
        public DietType DietType { get; set; }

        public Animal()
        {
            Console.WriteLine("Make an animal!");
        }

        public void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves");
        }
    }
}
