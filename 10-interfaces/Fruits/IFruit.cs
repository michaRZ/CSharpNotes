using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interfaces.Fruits
{
    public interface IFruit
    {
        // PROPERTIES
        string Name { get; }
        bool IsPeeled { get; }

        // METHODS
        string Peel();

    }
}
