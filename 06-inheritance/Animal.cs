using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_inheritance
{
    // enum - defined in namespace, seperately form class

    public enum DietType { Herbivore = 1, Omnivore, Carnivore } // applied '1' to Herbivore to force index to be 1, 2, 3 (instead of 0, 1, 2)

    public abstract class Animal    
        // 'abstract' makes Animal a 'base class', giving starting point to build off of, like a template
        // Can't make just an animal, but all animals created, whether Mammal etc will have base properties of Animal
    {
        // fields
        // properties
        // constructors
        // methods

        public int NumberOfLegs { get; set; }
        public bool HasFur { get; set; }
        public DietType DietType { get; set; }


        // CONSTRUCTORS
        public Animal()
        {
            Console.WriteLine("This is the Animal constructor");
        }


       // public abstract void Attack()   // method returns nothing because it is VOID
       
        public virtual void MakeSound() // default MakeSound() for all animals; VIRTUAL makes this implementation customizeable
        {
            Console.WriteLine("AAOOOOOGA");
        }
    }
}
