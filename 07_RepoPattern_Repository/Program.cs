using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepoPattern_Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach (int num in Enumerable.Range(1, 100)) { Console.WriteLine(((num%3==0?"Fizz":"") + (num%5==0?"Buzz":"")) || num.ToString() ); }
            ProgramUI UI = new ProgramUI();
            UI.Run();
        }
    }
}
