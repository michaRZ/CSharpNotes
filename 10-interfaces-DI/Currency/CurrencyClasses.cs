using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interfaces_DI.Currency
{
    public class Penny : ICurrency
    {
        // Phat arrow or Lambda, => is a way to simplify bodies, in this context it makes those properties read-only, no set

        public string Name => "Penny";

        public decimal Value => 0.01m;
    }


    public class Nickel : ICurrency
    {
        public string Name { get; } = "Nickel";     // diff way of assigning value to property, same as above Lambda expression for Penny

        public decimal Value                        // yet another diff way of assigning value to property
        {
            get
            {
                return 0.05m;
            }
        }
    }


    public class Dime : ICurrency
    {
        public string Name => "Dime";

        public decimal Value => 0.10m;
    }


    public class Dollar : ICurrency
    {
        public string Name => "Dollar";

        public decimal Value => 1.00m;
    }


    public class ElectronicPayment : ICurrency
    {
        public string Name => "Electronic Payment";

        public decimal Value { get; } 

        public ElectronicPayment(decimal paymentValue)
        {
            Value = paymentValue;
        }

    }
}
