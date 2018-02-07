using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACMTests
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void OrderDateTest()
        {
            //Arrange
            var order = new Order();
            var expected = DateTime.UtcNow;
            //Act
            var actual = DateTime.UtcNow;
            //Assert
            Assert.AreEqual(expected,actual);

        }
    }
}
