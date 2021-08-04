using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_classes
{
    public class Greeter // make public so it can be accessed elsewhere
    {   
        // 1 - access modifier => visibility in the program (public)
        // 2 - return type => what the method gives back (in this case, nothing)
        // 3 - name => uses PascalCase
        // (3 & 4) - method signature => the method name(3) and the parameters(4)
        // 4 - parameters => what we need to pass to the method
        // 5 - statements or method body => code to execute

        // 1    2       3       4   
        public void SayHello(string name)
        {
            // 5
            Console.WriteLine($"Hello {name}!");
        }


        // Overload - same name, different signature
        public void SayHello()
        {
            Console.WriteLine("Hello stranger");
        }

        // 

        Random _randy = new Random(); // use '_'(field)  in variable name '_randy' so that this is avaialble to the whole class

        public void RandomGreeting()
        {
            string[] availableGreetings = new string[] { "Hello", "Hi", "Greetings", "Sup", "Good afternoon", "Howdy", "What's poppin" }; // 7 greetings in array, indexes are 0, 1, 2, 3, 4, 5, 6
            int randomNumber = _randy.Next(0, availableGreetings.Length); // set min value and max value (remember, will EXCLUDE max value). Total length or array is 7 greetings, and since our index starts at '0', indexes 0-6 will be available. Would be same as writing '(0, 7)' as min and max
            string randomGreeting = availableGreetings[randomNumber];
            Console.WriteLine(randomGreeting);

        }
    }

}
