using _10_interfaces_DI.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _10_interfaces_DI
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            ICurrency dime = new Dime();

            Assert.AreEqual(0.1m, dime.Value);
            Assert.AreEqual("Dime", dime.Name);
        }


        // Convert and Casting are different actions
        // convert changes both the type and value to match
        // casting just changes the type, and if the value doesn't apply to the new type the cast won't work


        [DataTestMethod]
        [DataRow(37.25)]    // can only use primitives in DataRow so we must take value as double, then convert to decimal
        [DataRow(1.50)]
        [DataRow(9.73)]
        public void EPaymentTests(double paymentValue)
        {
            decimal convertedValue = Convert.ToDecimal(paymentValue);
            var ePayment = new ElectronicPayment(convertedValue);

            Assert.AreEqual(convertedValue, ePayment.Value);
            Assert.AreEqual("Electronic Payment", ePayment.Name);
        }
    }
}
