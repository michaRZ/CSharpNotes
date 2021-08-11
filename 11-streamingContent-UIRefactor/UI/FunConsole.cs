using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_streamingContent_UIRefactor.UI
{
    public class FunConsole : IConsole
    {


        public void Clear()
        {
            Console.Clear();

            Random randy = new Random();
            int colorIndex = randy.Next(0, 16);

            Console.BackgroundColor = (ConsoleColor)colorIndex;
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            string input = Console.ReadLine();

            Console.WriteLine("Umm...");
            Thread.Sleep(100);
            Console.WriteLine("Okay...");
            Thread.Sleep(100);

            return input;
        }

        public void Write(string s)
        {
            Console.Write(s.ToUpper());
        }

        public void WriteLine(string s)
        {
            Random randy = new Random();
            int colorIndex = randy.Next(0, 16);

            Console.ForegroundColor = (ConsoleColor)colorIndex;

            bool capitalize = false;

            foreach (char letter in s)
            {
                if (capitalize)
                {
                    Console.Write(letter.ToString().ToUpper()); // chained method calls, here we must convert the char 'letter' to a string, then capitalize it with 'ToUpper'
                    capitalize = false;
                }
                else
                {
                    // Console.Write(letter.ToString().ToLower());
                    Console.Write(char.ToLower(letter));    // another version, this time to make 'letter' lowercase
                    capitalize = true;
                }
            }
            Console.Write('\n');

            Thread.Sleep(50);
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }
    }
}
