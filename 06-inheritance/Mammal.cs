using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_inheritance
{
    public class Mammal : Animal    // Mammal now INHERITS from Animal class
    {
        public string FurColor { get; set; }



        // CONSTRUCTOR
        public Mammal()
        {
            HasFur = true;
            NumberOfLegs = 4;
            Console.WriteLine("This is the Mammal constructor");
        }
        
        public override void MakeSound()    // overrides MakeSound() default implemention
        {
            Console.WriteLine("ROAR!");
        }
    }




    public class Horse : Mammal
    {
        public double Speed { get; protected set; } = 30d;  // protected: like private + w/i inherited classes
        public Horse()
        {
         
        }
        public void Roar()
        {
            base.MakeSound();
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The {GetType().Name} says Neigh!");
        }
        public override string ToString()
        {
            return "HOOOOOOORSE";
        }
    }

    public class Mustang : Horse
    {
        // Mustang will inherit MakeSound() from above

        public Mustang()
        {
            Speed = 35d;
        }
    }



    public class Dog : Mammal
    {
        public bool HasFloppyEars { get; set; }

        public Dog()
        {
            FurColor = "blue merle";
        }
    }


}
