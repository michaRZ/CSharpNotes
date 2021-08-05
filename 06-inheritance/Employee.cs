using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_inheritance
{
    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }

        public int YearsWithCompany
        {
            get
            {
                double totalTime = (DateTime.Now - HireDate).TotalDays; // first part gives a TimeSpan, run with .TotalDays to get days
                return (int)Math.Floor(totalTime);  // the (int) 'casts' the value and tries to return it as an int instyead of a double
                // return Convert.ToInt32(Math.Floor(totalTime));   // does same thing as above
            }
        }
    }

    public class HourlyEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
        public double HoursWorked { get; set; }
    }

    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
    }
}
