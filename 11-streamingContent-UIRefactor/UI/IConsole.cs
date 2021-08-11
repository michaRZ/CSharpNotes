using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_streamingContent_UIRefactor.UI
{
    public interface IConsole
    {
        void WriteLine(string s);
        void WriteLine(object o);   // C# has implicit Convert.ToString() for objects
        void Write(string s);
        void Clear();
        string ReadLine();
        ConsoleKeyInfo ReadKey();

    }
}
