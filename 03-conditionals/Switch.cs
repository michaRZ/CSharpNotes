using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void SwitchCase()
        {
            int input = 1;

            // Switch cases - really good for navigation in an application
            // similar to If Else, except that you must explicitly break the flow
            switch (input)
            {
                case 1: // 'case' similar to 'if'; '1' refers to the value of 'input'
                    Console.WriteLine("Hello 1");
                    break; // similar to 'else' breaking out of if else statement
                case 2:
                    Console.WriteLine("Hello 2 You");
                    break;
                case 3:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine("Hi, you're odd");
                    break;
                default: // Triggers if no cases are met
                    Console.WriteLine("Default reply");
                    break;
            }


            // If version
            if (1)
            {
                Console.WriteLine("hello 1");
            }
            else if (input == 2)
            {
                Console.WriteLine("hello 2 you");
            }
            else if (input % 2 != 0) // checks remainder after input is divided by 2. If there is a remainder (!= 0) statement will trigger
            {
                Console.WriteLine("hi, you're odd");
            }
            else
            {
                Console.WriteLine("default reply");
            }
        }
    }
}
