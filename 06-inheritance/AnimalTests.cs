using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_inheritance
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // new up instance of Animal called 'animalOne'
            //  Animal animalOne = new Animal();
            //  animalOne.NumberOfLegs = 6;

            Mammal Nancy = new Mammal(); // calls Animal constructor first, then applies Mammal constructor
            Console.WriteLine(Nancy.NumberOfLegs);
            Console.WriteLine(Nancy.HasFur);

            Nancy.MakeSound();


            Horse horse = new Horse();
            horse.MakeSound();
            horse.Roar();
            Console.WriteLine(horse.ToString());

            Mustang musty = new Mustang();
            musty.MakeSound();
        }

    }
}
