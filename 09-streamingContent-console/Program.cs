using _09_streamingContent_console.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_streamingContent_console
{
    class Program
    {
        // args = array of options or commands you can type after the name of the program
        static void Main(string[] args)
        {
            // example:
            /* if (args[0] == "-v" || args[0] == "--version")
            {
                Console.WriteLine([the app version number\);
            } */

            // this is where you set up the app, deal with input, etc
            ProgramUI ui = new ProgramUI();
            ui.Run();

            // Not static (like below) bc we need to use a field
            // ProgramUI.Run();
        }
    }
}
