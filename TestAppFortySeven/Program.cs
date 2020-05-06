using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestAppFortySeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Nancy", "White", Cat.PatternType.Splotched);
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"{cat.Name} is a {cat.FurColor} {cat.Pattern} cat");

            // Thread.Sleep(5000);
            // Console.WriteLine("Bye!");
            // Thread.Sleep(1000);

            Console.WriteLine($"{cat.Name} has killed {cat.Kills.Count} little critters");

            cat.AddKill(Cat.Creature.Moth);
            cat.AddKill(Cat.Creature.Moth);
            cat.AddKill(Cat.Creature.Spider);
            cat.AddKill(Cat.Creature.Moth);

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"{cat.Name} has killed {cat.Kills.Count} little {(cat.Kills.Count == 1 ? "critter" : "critters")}");

            Console.WriteLine($"{cat.Name} has killed {cat.GetKillCount(Cat.Creature.Spider)} spider(s)");
            Console.WriteLine($"{cat.Name} has killed {cat.GetKillCount(Cat.Creature.Moth)} moth(s)");

            cat.ChangeName();

            Console.ForegroundColor = ConsoleColor.Green;
            cat.ListKills();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\nH");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("E");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("L");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("L");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("O");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("!\n\n");

        }
    }
}
