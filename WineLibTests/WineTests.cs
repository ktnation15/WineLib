using Microsoft.VisualStudio.TestTools.UnitTesting;
using WineLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineLib.Tests
{
    [TestClass()]
    public class WineTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            // Arrange
            Wine wine = new Wine();
            wine.Id = 1;
            wine.Manufacturer = "Fine";
            wine.Year = 2020;
            wine.Price = 100;
            wine.Rating = 5;
            // Act
            string result = wine.ToString();
            // Assert
            Assert.AreEqual("Id: 1, Manufacturer: Fine, Year: 2020, Price: 100, Rating: 5", result);
        }

        [TestMethod()]
        public void ValidateManufacturerTest()
        {
            // Arrange
            Wine wine = new Wine();
            wine.Manufacturer = "Abel";
            // Act
            wine.ValidateManufacturer();
            // Assert
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void ValidateManufacturerTestException()
        {
            // Arrange
            Wine wine = new Wine();
            wine.Manufacturer = "A";
            // Act
            // Assert
            Assert.ThrowsException<ArgumentException>(() => wine.ValidateManufacturer());
        }
        [TestMethod]
        public void ValidatePriceTest()
        {
            // Arrange
            Wine wine = new Wine();
            wine.Price = 100;
            // Act
            wine.ValidatePrice();
            // Assert
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void ValidatePriceTestException()
        {
            // Arrange
            Wine wine = new Wine();
            wine.Price = -100;
            // Act
            // Assert
            Assert.ThrowsException<ArgumentException>(() => wine.ValidatePrice());
        }
        [TestMethod]
        public void ValidateRatingTest()
        {
            // Arrange
            Wine wine = new Wine();
            wine.Rating = 4.5m;
            // Act
            wine.ValidateRating();
            // Assert
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void ValidateRatingTestException()
        {
            // Arrange
            Wine wine = new Wine();
            wine.Rating = 1.5m;
            // Act
            // Assert
            Assert.ThrowsException<ArgumentException>(() => wine.ValidateRating());
        }
    }
}