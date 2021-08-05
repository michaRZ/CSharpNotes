using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_classes
{
    [TestClass]
    public class PersonTests 

        // Unit test reads the info from Person.cs Person class to make what it's told to
        // takes the info it needs, stores it, the displays if asked for Console.WriteLine()

    {
        [TestMethod]
        public void PersonPropertyTests()
        {

            // Use empty constructor and manually set every value 
            Person firstPerson = new Person();

            firstPerson.FirstName = "Michaela";
            firstPerson.LastName = "Zuber";
            // firstPerson.FullName = "Michaela Zuber"; // no longer functional, since we made FullName 'get' only; pulls from user input FirstName and LastName
            firstPerson.DateOfBirth = new DateTime(1994, 6, 15);
            firstPerson.SocialSecurity = "123-45-6789";
            firstPerson.CreditScore = 780;

            Console.WriteLine($"{firstPerson.FullName} was born on {firstPerson.DateOfBirth.ToShortDateString()}");

            Console.WriteLine($"{firstPerson.LastName} {firstPerson.SocialSecurity}");



            // Use Person overloaded Constructor to make a second person
            Person secondPerson = new Person("Michael", "Zuber", new DateTime(1993, 3, 19), "123-45-6789", 800);

            Console.WriteLine($"{secondPerson.FullName} was born on {secondPerson.DateOfBirth.ToShortDateString()}");

            secondPerson.Transport = new Vehicle("Ford", "F-150", 53000, VehicleType.Truck);

            Console.WriteLine($"{secondPerson.FirstName} drives a {secondPerson.Transport.Make} {secondPerson.Transport.Model}");

            Assert.AreEqual("Michael Z", secondPerson.FullName);

            secondPerson.Transport.TurnOn();

            Assert.IsTrue(secondPerson.Transport.IsRunning);
        }

    }
}
