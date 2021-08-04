using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_classes
{
    // public - so that it accesible outside of itself
    // set as 'enum' instead of string so that we can be sure we will ALWAYS get these properties when calling VehicleType
    // guarantees one of these VehicleTypes must be used when asisgning; if none explicitly chosen, enum will default to index 0, which is "Car"
    public enum VehicleType {  Car, Truck, Van, Spaceship, Plane}

    public class Vehicle
    {
        // classes kind of like nouns
        // properties are variables that exist within the entire class - kind of like adjectives
        // class methods are like verbs



        // Constuctors
        // put constructors at top of object type

        // Hidden implicit constructor
        // Needs to be manually written in order to be accessed if there is any other constructor present (like the one below)
        public Vehicle () { }


        // Overloaded Constructor
        // this means we cannot have empty Vehicle object, all parameters must be filled, so we have to include the above empty constructor
        // always put simpler constructors before more complicated constructors
        public Vehicle(string make, string model, double mileage, VehicleType type)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = type;
            LeftIndicator = new Indicator();
            RightIndicator = new Indicator();
        }



        // 1 - access modifier => Where can this be seen? // public allows you to use it outsude of this 
        // 2 - type => type of property as a held value
        // 3 - name => Name of the property method, must be Pascal case (every first letter must be capitalised)
        // 4 - getters and setters => 


        // 1    // 2  // 3   // 4
        public string Make { get; set; }

        public string Model { get; set; }

        public double Mileage { get; set; } // use a 'double' bc Mileage will be a number, possibly with a decimal

        public VehicleType TypeOfVehicle { get; set; }

        public bool IsRunning { get; private set; } // private set - means it can only be set while we are within Vehicle class



        public void TurnOn()
        {
            IsRunning = true;

            Console.WriteLine("You turn on the vehicle.");
        }

        public void TurnOff()
        {
            IsRunning = false;

            Console.WriteLine("You turn off the vehicle.");
        }




        // Create turn signals
        // call public Indicator class

        public Indicator RightIndicator { get; set; }
        public Indicator LeftIndicator { get; set; }


        // Create methods to use Indicators
        public void TurnRight()
        {
            RightIndicator.TurnOn();
            LeftIndicator.TurnOff();
        }

        public void TurnLeft()
        {
            RightIndicator.TurnOff();
            LeftIndicator.TurnOn();
        }

        public void TurnOnHazards()
        {
            RightIndicator.TurnOn();
            LeftIndicator.TurnOn();
        }

        public void ClearIndicators()
        {
            RightIndicator.TurnOff();
            LeftIndicator.TurnOff();
        }



    }

    public class Indicator
    {
        // Create a class called Indicator that has a property called IsFlashing
        // IsFlashing should have a private set
        // The Indicator class also then needs the methods required to change the state of the IsFlashing Property

        public bool IsFlashing { get; private set; }


        public void TurnOn()
        {
            IsFlashing = true;

            Console.WriteLine("Your blinker is on.");
        }

        public void TurnOff()
        {
            IsFlashing = false;

            Console.WriteLine("Your blinker is off.");
        }

    }
}
