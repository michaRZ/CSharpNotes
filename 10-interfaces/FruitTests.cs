using _10_interfaces.Fruits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _10_interfaces
{
    [TestClass]
    public class FruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            // Can declare IFruit, but cannot make new instance of IFruit. 
            // Calling IFruit because Banana() class has only properties of IFruit
            IFruit banana = new Banana();

            string output = banana.Peel();
            Console.WriteLine(output);

            Assert.IsTrue(banana.IsPeeled);
        }



        [TestMethod]
        public void InferFacesInCollections()
        {
            // in this case, we need to call the class Orange, bc it has more properties than our IFruit interface (squeeze) that we need to access
            Orange orange = new Orange();


            // var is wildcard type - says whatever you set me to, that's what I am
            // important bc C# is a strongly typed language
            var fruitSalad = new List<IFruit>
            {
                new Banana(),
                new Grape(),
                orange
            };

            foreach (var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());

                Assert.IsInstanceOfType(fruit, typeof(IFruit));

                // can't use this bc we can only access IFruit properties and methods in this collection
                // fruit.Squeeze();
            }

            // can call method Squeeze on orange only
            Console.WriteLine(orange.Squeeze());

            Assert.IsInstanceOfType(orange, typeof(Orange));
        }

        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}";
        }



        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();

            var output = GetFruitName(grape);

            Console.WriteLine(output);

            Assert.IsTrue(output.Contains("This fruit is called Grape")); // checking if actual output matches GetFruitName() output
        }



        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Orange(),
                new Banana(true),
                new Grape()
            };

            foreach (var fruit in fruitSalad)
            {
                // Pattern matching w/ 'is' (is: a struct)
                // if fruit is type Orange, create new variable/object of it called orange
                if (fruit is Orange orange)
                {
                    if (orange.IsPeeled)
                    {
                        Console.WriteLine("It's a peeled orange.");
                        Console.WriteLine(orange.Squeeze());
                    }
                    else
                    {
                        Console.WriteLine("It's an orange");
                    }
                }
                // using typeof check
                else if (fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("It's a grape");

                    // Can cast type over var 'fruit' to make it grape
                    // we do this is we are not pattern matching, like above w/ orange
                    var grape = (Grape)fruit;
                    Console.WriteLine(grape.Peel());
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("It's a peeled banana");
                }
                else
                    Console.WriteLine("It's a banana");
            }

        }
    }
}
