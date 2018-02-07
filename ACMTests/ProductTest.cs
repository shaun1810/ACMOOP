using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMTests
{
    [TestClass()]
   public class ProductTest
    {
        [TestMethod()]
        public void ProductNameTest()
        {
            //Arrange
            var product = new Product();
            var expected = "Xbox One";
            //Act
            var actual = product.ProductName = "Xbox One";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DescriptionTest()
        {
            //Arrange
            var Product = new Product();
            var expected = "Games Console";
            //Act
            var actual = Product.Description = "Games Console";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CurrentPriceTest()
        {
            //Arrange
            var product = new Product();
            var expected = 239.50m;

            //Act
            var actual = product.CurrentPrice = 239.50m;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void printProductTest()
        {
            //Arrange
            var product = new Product();
            product.ProductName = "Xbox one";
            product.Description = "Games Console";
            product.CurrentPrice = 250.99m;
            var expected = "Product Name:Xbox one\r\nDescription:Games Console\r\nCurrent Price:250.99";
            //Act
            var actual = product.PrintProduct();
            //Assert
            Assert.AreEqual(expected,actual);
        }

    }
}
