using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_classes
{
    // public - so that it accesible outside of itself
    public enum VehicleType {  Car, Truck, Van, Spaceship, Plane}

    public class Vehicle
    {
        // classes kind of like nouns
        // properties are variables that exist within the entire class - kind of like adjectives

        // 1 - access modifier => Where can this be seen? // public allows you to use it outsude of this 
        // 2 - type => type of property as a held value
        // 3 - name => Name of the property method, must be Pascal case (every first letter must be capitalised)
        // 4 - getters and setters => 


        // 1    // 2  // 3   // 4
        public string Make { get; set; }

        public string Model { get; set; }

        public double Mileage { get; set; } // use a 'double' bc Mileage will be a number, possibly with a decimal

        public VehicleType TypeOfVehicle { get; set; }

    }
}
