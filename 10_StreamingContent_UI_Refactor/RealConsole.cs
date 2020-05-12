using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamingContent_UI_Refactor
{
    public class RealConsole : IConsole
    {
        int counter = 0;
        public void Clear()
        {
            Console.Clear();
        }
        public void WriteLine(string s)
        {
            if (counter % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            } else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            
            Console.WriteLine(("So, like, " + s).ToUpper());
            counter++;
        }
        public void WriteLine(object o)
        {
            if (counter % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(o);
            counter++;
        }
        public void Write(string s)
        {
            Console.Write(s);
        }
        public string ReadLine()
        {
            return Console.ReadLine();
        }
        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }
    }
}
