using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_inheritance
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            HourlyEmployee employee1 = new HourlyEmployee();
            employee1.HireDate = new DateTime(1982, 5, 11);
            Console.WriteLine($"{employee1.Name} has been with the company for {employee1.YearsWithCompany} years.");

            SalaryEmployee employee2 = new SalaryEmployee();
            employee2.SetFirstName("Michael");
            employee2.SetLastName("Scott");
            employee2.Salary = 80000m;
            employee2.HireDate = new DateTime(2019, 4, 10);
            Console.WriteLine($"{employee2.Name} is making ${String.Format("{0:n0}", employee2.Salary)} after {employee2.YearsWithCompany} years with the company");
        }

        
    }
}
