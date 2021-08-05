using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_classes
{
    public class Person
    {

        // CONSTRUCTORS!

        // Empty constructor first
        public  Person() { }


        // expanded, overloaded constructor
        public Person(string firstName, string lastName, DateTime dob, string socSec, int credit)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
            SocialSecurity = socSec;
            CreditScore = credit;
        }



        // MAKE A PERSON
        public string FirstName { get; set; }


        // Backing field
        // private means it can only be set from methods or constructors w/i the class
        private string _lastName;
        public string LastName 
            // return _lastName field's first letter only
        { get { return _lastName[0].ToString(); }
            // assign the value to _lastName
            set { _lastName = value;  } 
        }


        // Interpolate FirstName, LastName to make FullName from user inout
        // Readonly property, no set
        public string FullName 
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        public DateTime DateOfBirth { get; set; }


        // Backing field
        // XXX-XX-XXXX
        private string _socialSecurity;
        public string SocialSecurity
        {
            get { return _socialSecurity.Split('-')[2]; } // .Split splits strings into array of sections at the specified char '-'
            set { _socialSecurity = value; }
        }


        public int CreditScore { get; set; }
        public Vehicle Transport { get; set; }
    }
}
