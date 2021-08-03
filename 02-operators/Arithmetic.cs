using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {

            int a = 22;
            int b = 15;


            // Can do math with addition, subtraction, multiplication, division, and remainder
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b; // and int is an int is an int - will not get precise number if dividing, so remember to use Remainder
            int remainder = a % b;

            DateTime today = DateTime.UtcNow;
            DateTime someDay = new DateTime(1980, 1, 5);
            TimeSpan timeSpan = today - someDay;
        }
    }
}
