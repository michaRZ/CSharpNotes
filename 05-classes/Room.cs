using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_classes
{
    public class Room
    {

        /* Create a Room class that has three properties: one each for the length, width, and height.
        Create a method that calculates total square footage.
        We also would like to include some 'constants' that the define a minimum and maximum length, width, and height.
        When setting the properties, make sure to compare the values to the min/max and only set them if the value is valid.

        Bonus:
        Create a method that calculates total lateral surface area. (LSA)
        Only allow the properties to be set from inside the class itself (PRIVATE)
        Throw an exception if the given value is outside the permitted range.
        Test the code like we did with the Vehicle tests. */


        // CONSTRUCTORS

        public Room() { }


        public Room(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }



        // Class Properties


        // set _fields at top for clarity
        private double _length;
        private double _width;
        private double _height;

        public double Length
        {
            get { return _length; }
            set
            {
                if (value < MinLength || value > MaxLength)
                {
                    // Don't store, throw an exception - stops run of program and displays custom error message
                    throw new ArgumentException($"The length needs to be between {MinLength} and {MaxLength}");
                }
                // else
                // don't need 'else' if throwing ArgumentException, automatically moves on if argument acceptable
                 _length = value;
            }
        }



        public double Width
        {
            get { return _width; }
            set
            {
                if (value < MinWidth || value > MaxWidth)
                {
                    throw new ArgumentException($"The width needs to be between {MinWidth} and {MaxWidth}");
                }
                _width = value;
            }
        }



        public double Height
        {
            get { return _height; }
            set
            {
                if (value < MinHeight || value > MaxHeight)
                {
                    throw new ArgumentException($"The height needs to be between {MinHeight} and {MaxHeight}");
                }
                _height = value;
            }
        }



        // Private constants so they are hidden hard rules for inputs, that cannot be changed
        private const double MaxLength = 40;
        private const double MinLength = 5;

        private const double MaxWidth = 30;
        private const double MinWidth = 3;

        private const double MaxHeight = 12;
        private const double MinHeight = 4;



        // Calc sq. ft.
        public double TotalSqFt
        {
            get
            {
                return Length * Width;
            }
        }

        // Calc Lateral Surface Area ( 2H(L+W) )
        public double LSA
        {
            get
            {
                return (2 * Height) * (Length + Width);
            }
        }




    }
}
