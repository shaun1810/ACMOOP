using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMTests
{
    [TestClass]
    public class OrderItemTest
    {
        [TestMethod]
        public void QuantityTest()
        {
            //Arrange
            var orderItem = new OrderItem();
            var expected = 4;
            //Act
            var actual = orderItem.Quantity = 4;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
