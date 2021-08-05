using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_inheritance
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string Name
        {
            get
            {
                string fullName = $"{_firstName} {_lastName}";
                return string.IsNullOrWhiteSpace(fullName) ? "Unnamed" : fullName; // checks if space is empty. If true, print Unnamed, it false print fullName
      
            }
        }


        // the following two methods do the same thing as 'set;', just separately
        public void SetFirstName(string name) // takes string called name and sets it to be the value of _firstName
        {
            _firstName = name;
        }

        public void SetLastName(string name)
        {
            _lastName = name;
        }
    }

}
