using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_operators
{
    [TestClass]
    public class Comparisons
    {
        [TestMethod]
        public void Comparison()
        {
            //Comparisons use operators like greater than, greater than or equal to, etc


            // Equal comparison
            int age = 27;
            string username = "micha";

            // checks if 'age' is equal to 41, true or false. (below example would be false)
            bool equals = age == 41;

            // check name, example should show true
            bool userIsMicha = username == "micha";



            // Inequals comparison
            bool notEqual = age != 112;
            bool userIsNotJustin = username != "michael";


            // Not all things are equal, reference types aren't understood the same way
            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            // we have two lists of the same type with the same contents, but they are still not considered equal
            // this is because they are reference types and saved as separate objects
            bool isEqual = firstList == secondList;


            // > , >= , < , <=
            bool greaterThan = age > 12;
            bool greaterThanOrEqual = age >= 28;
            bool lessThan = age < 66;
            bool lessThanOrEqual = age <= 21;

        }

        [TestMethod]
        public void AndOr()
        {
            bool trueValue = true;
            bool falseValue = false;

            // Or
            bool trueOrTrue = trueValue || trueValue; // using 'or' || returns 'true' if either or both of the arguments are true; this one returns 'true'
            bool trueOrFalse = trueValue || falseValue; // returns 'true'
            bool falseOrFalse = falseValue || falseValue; // returns 'false'

            // And
            bool trueAndTrue = trueValue && trueValue; // 'and' && returns 'true' ONLY if BOTH arguments are true; this one is true
            bool trueAndFalse = trueValue && falseValue; // returns 'false' bc both areguments are NOT true
            bool falseAndFalse = falseValue && falseValue; // returns 'false', bc both arguments are false; like "two wrongs don't make a right"
        }
    }
}
