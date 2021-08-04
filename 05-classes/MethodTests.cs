using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace _05_classes
{
    [TestClass]
    public class MethodTests
    {
        [TestMethod]
        public void GreetingTests()
        {
            // Instantiate object 'greeter' of the Greeter class
            Greeter greeter = new Greeter();

            // Call a method ('SayHello') from our variable of that object
            // we will supply argument 'Michaela' to the 'name' parameter in .SayHello that we created in Greeter.cs
            greeter.SayHello("Michaela");

            // Calling our overloaded method from Greeter.cs
            greeter.SayHello();


            // Get random greetings from RandomGreeting class in Greeter.cs
            greeter.RandomGreeting();
            Thread.Sleep(5);
            greeter.RandomGreeting();
            Thread.Sleep(5);
            greeter.RandomGreeting();

            // can possibly get same random output in a run due to CPU space
            // can use Thread.Sleep() and input a time in ms (ex: 5) to force computer to wait a brief period before running again
            // must enable Using statement by hovering on Thread, 'Ctrl + . ' 
        }



        [TestMethod]
        public void Calculations()
        {
            // 'new up' instance of Calculator from Calculator.cs

            Calculator calculator = new Calculator();
            int sum = calculator.Add(8, 12);
            Assert.AreEqual(20, sum); // Assert is a built-in testing tool; tests if 'sum' is equal to 20
            // Assert.AreEqual(21, sum); // returns FAILED, because the 'sum' is not equal to 21

            // use Overload .Add from Calculator.cs
            double sumTwo = calculator.Add(4.3, 9d); // put 'd' after an interger when working with other doubles to ensure C# recognizes it
            Assert.AreEqual(13.3, sumTwo);


            // use Divide method
            int quotient = calculator.Divide(16, 4);
            Console.WriteLine(quotient);


            double quotientTwo = calculator.Divide(16, 3d); // use suffix 'd' tp specify double, so that we can return a double, which will appear as a decimal 
            Console.WriteLine(quotientTwo);


           
        }

        [TestMethod]
        public void AgeCalculations()
        {
            Calculator calculator = new Calculator();
            // 6, 15, 1994
            // DateTime dob = DateTime(1994, 6, 15);
            int age = calculator.CalculateAge(new DateTime(1994, 6, 15));
            Console.WriteLine($"Michaela is {age} years old.");

        }
    }
}
