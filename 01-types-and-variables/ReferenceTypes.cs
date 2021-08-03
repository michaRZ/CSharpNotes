using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_types_and_variables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            // Strings are groups of characters, represented in "".
            string declared;

            declared = "Now declared is initialised";

            string declaredAndInitialised = "This is declared and initialised!";

            string firstName = "Michaela";
            string lastName = "Raines-Zuber";

            // Concatenation
            string concatenatedFullName = firstName + " " + lastName; // prints "Michaela Raines-Zuber"

            // Composite Formatting
            // Reference values by utilising list within format
            // Usually used in Console.WriteLine [ ex Console.WriteLine("Hi, I'm {0}!", firstName); ]
            string compositeFormatting = string.Format("{0} {1}", firstName, lastName);

            // Interpolation
            // most common, most useful
            // Must use '$' to break-out of quotes, so we can used brackets to call our variables and inoyt isn't interpreted literally as a string
            string interpolatedFormating = $"{firstName} {lastName}";

            Console.WriteLine(firstName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(compositeFormatting);
            Console.WriteLine(interpolatedFormating);
        }

        [TestMethod]
        public void Collections()

        {
            // "databases are just collections"

            // Arrays
            // Collection of strings
            string greeting = "Greetings";

            string[] stringArray = { "Hello", "Hi", "Goodbye", greeting};

            // Call indexed item from our collection 'stringArray'. Grab "Goodbye", which it at index 2
            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            // Rewrite index 2 as "Good Morning"
            stringArray[2] = "Good Morning";
            Console.WriteLine(stringArray[2]);


            // Lists
            // Declare listss, initialise with 'new' keyword
            // Add using statement (ctrl + . , then choose using statement) (check top of page for list of statements active)
            List<string> listOfStrings = new List<string>();
            List<int> listOfInts = new List<int>();

            // Add a new string to our list "listOfStrings"
            listOfStrings.Add("Here's a string");

            // Can also add numbers - will pass as string
            listOfStrings.Add("292919");

            // Add integer to our list "listOfInts"
            listOfInts.Add(7);


            // Queues
            // first in, first out (opposite of Stacks, first in, last out)

            // declare and initialise a queue
            Queue<string> firstInFirstOut = new Queue<string>();

            // Add to queue with '.Enqueue'
            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm next");

            // Call next up item with "Peek()"
            Console.WriteLine(firstInFirstOut.Peek());

            // Must always work with first item in list, like customers in a line
            // Use '.Dequeue' to work with that item and "cross it off"
            firstInFirstOut.Dequeue();

            // Now Peek() will return next item up
            Console.WriteLine(firstInFirstOut.Peek());


            // Stacks
            // first in, last out / last in, first out
            // Uses different methods than Queue. Sorta outdated

            Stack<string> firstInLastOut = new Stack<string>();

            firstInLastOut.Push("Bottom bun");
            firstInLastOut.Push("Meat");
            firstInLastOut.Push("Top bun");

            Console.WriteLine(firstInLastOut.Peek());


            // Dictionaries
            // similar to lists, but difficult
            // uses key-value pairs - when I look up the key, I get the value
                    //key   //value
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            keyAndValue.Add(7, "Agent");

            string atSeven = keyAndValue[7];

            Console.WriteLine(atSeven);


            Dictionary<string, string> dictionaryDefinition = new Dictionary<string, string>();

            dictionaryDefinition.Add("Duck", "It quacks");

            string definitionOfDuck = dictionaryDefinition["Duck"];

            Console.WriteLine(definitionOfDuck);


            // Note: parentheses are typically used for passing a value through, like in a method for example
            // When in doubt, try brackets
        }

        [TestMethod]
        public void Classes()
        {
            // Classes
            Random rng = new Random();

            // pull in random number with 'Next' method
            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);
        }
    }
}
