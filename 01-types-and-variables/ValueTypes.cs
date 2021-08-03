using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_types_and_variables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            // Declared Bool
            // Bools technically initialise 'false' if no assigned value set
            bool declared;

            // Set a value/initialise the bool
            declared = true;

            // Or declare and initialise all in one go
            bool declaredAndInitialised = false;

            // Assign different value after initial assignment
            declaredAndInitialised = true;
        }

        [TestMethod]
        public void Characters()
        {
            // char uses single-quotation for a single character
            // Strings are chars stringed together, represented in double-quotes
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n'; // new-line char, forces content onto new line
        }

        [TestMethod]
        public void WholeNumbers()
        {
            // 4 types hold various amounts of data based on bits
            // ex 2^16 = short (range is 65536, center on 0)
            byte byteMin = 0;
            byte byteMax = 255;
            short shortMin = -32768;
            short shortMax = 32767;
            int intMin = -2147483648;
            int intMax = 2147483647;
            long longMin = -9223372036854775808;
            long longMax = 9223372036854775807;

            // int16 is equal short 
            // int32 is equal to int
            // int64 is equal to long

            int a = 15;
            int b = -2;
        }

        [TestMethod]
        public void Decimals()
        {
            // Decimals have 3 types, having various precision limits
            float floatExample = 1.29294894f; // must specify 'float' with 'f' suffix, can hold 9 digits
            double doubleExample = 1.74927981526483d; // 'd' suffix optional, decimal type defaults to 'double' automatically
            decimal decimalExample = 1.4698026649893897267867983m; // 'm' suffix must be used for 'decimal', can hold more value than 'double'. Most precise, uses most memory.
        }


            // Scope for 'enum pastryType' placed OUTSIDE test method, within scope of Public Class, so all Test Methods can use it
            enum PastryType { Cake, Cupcake, Eclair, PetitFour, Croissant };

        [TestMethod]
        public void Enum()
        {
            // 2 parts - 'enum' declaration and assignment
            // Use Pascal capitalisation for methods, tests, and enums

            // Call 'PastryType', name, the call again with . and select from list
            PastryType myPastry = PastryType.Croissant;
            PastryType yourPastry = PastryType.PetitFour;
        }

        [TestMethod]
        public void Structs()
        {
            // Structs are simple values, some prebuilt in
            // bools are technically Structs - true/false

            // example:
            DateTime today = DateTime.Today; // pulls value from computer's setting
            DateTime birthday = new DateTime(1993, 3, 19); // saves entered date to 'birthday', must use 'new' and pass somehting into it, or it defaults to random date in early 1900s
        }
    }
}
