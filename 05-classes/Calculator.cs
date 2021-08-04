using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_classes
{
    public class Calculator // make public so it can be accessed elsewhere
    {
        // Addition method


        public int Add(int numOne, int numTwo) // create method called 'Add' that takes two paramters, numOne and numTwo
        {
            int sum = numOne + numTwo;
            return sum;
        }

        // overloaded Add method
        public double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

  



        // Subtraction

        public int Subtract(int numOne, int numTwo) // numOne and numTwo exist only in the method, so we can use the same names more than once if in another method
        {
            int difference = numOne - numTwo;
            return difference;
        }


        // overload Subtract method
        public double Subtract(double numOne, double numTwo)
        {
            return numOne - numTwo;
        }





        // Multiplication

        public int Multiply(int numOne, int numTwo)
        {
            int product = numOne * numTwo;
            return product;
        }


        // overload Multiply method
        public double Multiply(double numOne, double numTwo)
        {
            return numOne * numTwo;
        }






        // Division

        public int Divide(int numOne, int numTwo)
        {
            int quotient = numOne / numTwo;
            return quotient;
        }


        // overload Divide method - more realistic as most numbers don't divide perfectly to return an int. MUST specify double type w/ 'd'
        public double Divide(double numOne, double numTwo)
        {
            return numOne / numTwo;
        }


        // Remainder

        public int Remainder(int numOne, int numTwo)
        {
            int remain = numOne % numTwo;
            return remain;

        }





        // Age Calculation
        public int CalculateAge(DateTime birthDate) // get birthday
        {
            TimeSpan ageSpan = DateTime.Now - birthDate; // find difference of time between now and birthday
            double totalAgeInYears = ageSpan.TotalDays / 365.25; // divide days in ageSpan by 365.25 (to account for Leap Years) to get total years
            double ageRounded = Math.Floor(totalAgeInYears); // rounds total years  'double' down to whole number
            int years = Convert.ToInt32(ageRounded); // convert age to an integer called 'years'
            return years;
        }


    }
}
