using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppFortySeven
{
    
    class Cat
    {
        int x = 5;
        public enum Creature { Mouse, Moth, Spider }
        public enum PatternType { Striped = 1, Solid, Spotted, Splotched, Socks, Tuxedo }

        public string Name { get; set; }
        public string FurColor { get; set; }
        public PatternType Pattern { get; set; }
        public DateTime BirthDate { get; }
        public List<Creature> Kills { get; } = new List<Creature>();

        public Cat(string name, string furColor, PatternType pattern)
        {
            Name = name;
            FurColor = furColor;
            Pattern = pattern;
            BirthDate = DateTime.Now;
            // Kills = new List<Creature>();
        }

        public void AddKill(Creature creature)
        {
            Kills.Add(creature);
        }

        /*
        Old methods I don't need any more. Kept for reference
        public int GetMothCount()
        {
            int count = 0;
            foreach(Creature creature in Kills)
            {
                if (creature == Creature.Moth)
                {
                    count++;
                }
            }
            return count;
        }

        public int GetSpiderCount()
        {
            int count = 0;
            foreach (Creature creature in Kills)
            {
                if (creature == Creature.Spider)
                {
                    count++;
                }
            }
            return count;
        }
        */

        // Re-writing code to be better is called Refactoring
        public int GetKillCount(Creature type)
        {
            int count = 0;
            foreach (Creature creature in Kills)
            {
                if (creature == type)
                {
                    count++;
                }
            }

            return count;
        }


        public void ListKills()
        {
            for (int n=0; n<Kills.Count; n++)
            {
                Creature kill = Kills[n];
                if (n < (Kills.Count - 1))
                {
                    Console.Write(kill + ", ");
                } else
                {
                    Console.Write(kill);
                }

                // OR:
                // Console.Write(kill + (n < (Kills.Count - 1) ? ", " : ""));
            }
        }


        public void ChangeName()
        {
            string oldName = Name;
            Console.WriteLine("What would you like to call this cat?");
            string NewName = Console.ReadLine();
            Name = NewName;
            Console.WriteLine($"{oldName} is now known as {Name}");
        }

        public int getX()
        {
            return x;
        }
    }
}
