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
            // "new up" a new instance of Vehicle with the following syntax

            Vehicle firstVehicle = new Vehicle();

            firstVehicle.Make = "Nissan"; // assign a value "Nissan" to the property we created "Make"

            Console.WriteLine(firstVehicle.Make);

            firstVehicle.Model = "Skyline";
            firstVehicle.Mileage = 20000;

            firstVehicle.TypeOfVehicle = VehicleType.Car; // set the enum "VehicleType" we created to be ".Car"

            Console.WriteLine($"My car is a {firstVehicle.Make} {firstVehicle.Model} with {firstVehicle.Mileage} miles on it");
        }
    }
}
