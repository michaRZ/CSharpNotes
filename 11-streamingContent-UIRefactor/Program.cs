using _11_streamingContent_UIRefactor.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_streamingContent_UIRefactor
{
    public class Program
    {
        static void Main(string[] args)
        {
            //RealConsole console = new RealConsole();
            FunConsole console = new FunConsole();
            ProgramUI ui = new ProgramUI(console);
            ui.Run();
        }
    }
}
