using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.Animals
{
    public class Wolf : Animal
    {
        public Wolf()
        {
            HasTail = true;
            DietType = DietType.Carnivore;
            Console.WriteLine("This is the Wolf constructor");
        }

        public double ClawLength { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine("AWOOOOOOO!");
        }
    }

    public class Dog : Wolf
    {
        public Dog()
        {
            Console.WriteLine("This is a dog constructor");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Arf!");
        }
    }
}
