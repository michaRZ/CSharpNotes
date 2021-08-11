using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interfaces_DI.Currency
{
    public interface ICurrency
    {
        // these will be the bare minimum rules all our Currency classes must follow


        // Dependency Injection - when a class depends on some type of object being "injected" into it
        // DI allows for "interchangeable parts"


        // Like a CD in a CD player - CD player does nothing w/o CD in it, and CD is useless with no values(music, etc) on it
        // CD needs to have base properties (qualifcations) to be useable, like shiny bottom, being round, certain size, etc
        // CD also can be used with many interfaces(devices) based on what CD contains, like being a music CD, a game, a video, etc, and needs to be used with proper player (CD player, PlayStation, DVD player, etc)
        
        
        string Name { get; }
        decimal Value { get; }
    }
}
