using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;

            // if keyword
            // if(conditional in parentheses)
            // {statement in brackets}
            if(userIsHungry)
            {
                Console.WriteLine("You should eat a bunch of Oreos");
            }

            bool didYouStudy = false;
            if(!didYouStudy)
            {
                Console.WriteLine("You should've studied!");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {

            // Else
            // else will execute if the 'if' statement is not satisfied
            bool choresAreDone = false;

            if(choresAreDone)
            {
                Console.WriteLine("Have fun at the movies!");
            }
            else
            {
                Console.WriteLine("You must stay home and finish your chores, Cinderella!");
            }


            // Nesting Conditionals
            string input = "3";
            int totalSleep = int.Parse(input); // use int.Parse to convert 'string' number into 'int' to simplify if statements

            if(totalSleep >= 8)
            {
                Console.WriteLine("You should be well rested");
            }
            else
            {
                Console.WriteLine("You might be tired today");

                if(totalSleep < 4)
                {
                    Console.WriteLine("You should get more sleep!");
                }
            }

        }

        [TestMethod]
        public void IfElseIf()
        {
            // Else If
            // using Elif If links the statement to the outcome of the If statemnt above it
            // Once one is true, it executes output exits the IfElse conditional

            int age = 21;

            if(age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            else
            {
                Console.WriteLine("You're underage");

                if(age > 6)
                {
                    Console.WriteLine("You're a kid!");
                }
                else if(age > 0)
                {
                    Console.WriteLine("You're too young to use a computer");
                }
                else
                {
                    Console.WriteLine("You don't even exist yet...");
                }
            }


            // Combine if Else with AndOr Operators

            if(age >= 55)
            {
                Console.WriteLine("Senior Discount time!");
            }
            else if(age > 21 && age < 55)
            {
                Console.WriteLine("You're an adult, have a beer!");
            }
            else if(age == 21)
            {
                Console.WriteLine("You can drink now!");
            }
            else if(age <= 19)
            {
                Console.WriteLine("You're just a kid, you can't be in this bar.");
            }
            else
            {
                Console.WriteLine("You must be 20 because you got through all my If Else statements");
            }
        }
    }
}
