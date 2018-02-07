using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMTests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void FirstNameTest()
        {
            //Arrange
            var customer = new Customer();
            var expected = "Shaun";
            //Act
            var actual = customer.FirstName = "Shaun";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LastNameTest()
        {
            //Arrange
            var customer = new Customer();
            var expected = "Smith";
            //Act
            var actual = customer.LastName = "Smith";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FullNameTest()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "Shaun";
            customer.LastName = "Smith";
            var expected = "Shaun Smith";
            //Act
            var actual = customer.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrintCustomerTest()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "Shaun";
            customer.LastName = "Smith";
            customer.Email = "shaunsmith@msn.com";
            customer.HomeAddress = "123 Road";
            customer.WorkAddress = "20 Greek Road";
            var expected = "Customer Name: Shaun Smith\r\nEmail: shaunsmith@msn.com\r\nHome Address:123 Road\r\nWork Address:20 Greek Road";
            //Act
            var actual = customer.printCustomer();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
