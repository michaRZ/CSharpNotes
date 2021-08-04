using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_classes
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void PropertiesTest()
        {
            // "new up" a new instance of Vehicle with the following syntax so we can add properties to it

            Vehicle firstVehicle = new Vehicle();  // 'firstVehicle' is a variable of the Vehicle class

            firstVehicle.Make = "Nissan"; // assign a value "Nissan" to the property we created "Make"

            Console.WriteLine(firstVehicle.Make);

            firstVehicle.Model = "Skyline";
            firstVehicle.Mileage = 20000;

            firstVehicle.TypeOfVehicle = VehicleType.Car; // set the enum "VehicleType" we created to be ".Car"

            Console.WriteLine($"My car is a {firstVehicle.Make} {firstVehicle.Model} with {firstVehicle.Mileage} miles on it");
        }

        [TestMethod]
        public void MethodsTests()
        {
            // new up new instance of Vehicle

            Vehicle transport = new Vehicle();

            transport.TurnOn();
            Assert.IsTrue(transport.IsRunning);
            transport.TurnOff();




            // test Indicator

            Indicator myBlinker = new Indicator();

            myBlinker.TurnOn();
            Assert.IsTrue(myBlinker.IsFlashing);
            myBlinker.TurnOff();

        }

        [TestMethod]
        public void TurnSignalTests()
        {

            Vehicle myCar = new Vehicle();
            myCar.TurnOn();
            myCar.LeftIndicator = new Indicator();
            myCar.RightIndicator = new Indicator();


            // Turn right
            myCar.TurnRight();
            Console.WriteLine("Turning right");


            // Turn left
            myCar.TurnLeft();
            Console.WriteLine("Turning left");

            // use method CheckIndicators (below) to 
            CheckIndicators(myCar);
        }



        public void CheckIndicators(Vehicle myCar) // helper method to simplify so we don't have to write this code over and over
        {
            Console.WriteLine($"Right indicator: {myCar.RightIndicator.IsFlashing}");
            Console.WriteLine($"Left indicator: {myCar.LeftIndicator.IsFlashing}");
        }

        [TestMethod]
        public void Constructor()
        {
            // old way, old gross icky takes too long. So we made a constructor in Vehicle.cs
            Vehicle car = new Vehicle();
            car.Make = "Kia";
            car.Model = "Stinger";
            car.Mileage = 615;


            // Using overloaded constructor - much faster
            Vehicle rocket = new Vehicle("SpaceX", "Falcon Heavy", 300000, VehicleType.Spaceship);
            Console.WriteLine(rocket.Make);
            Console.WriteLine(rocket.Model);
        }
    }
}
