using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WSUniversalLib
{
    [TestClass]
    public class CalculationTests
    {
        private static readonly Calculation calculation = new Calculation();

        [TestMethod]
        public void GetQuantityForProduct_ValidParamsEasy_ReturnsInteger()
        {
            // Arrange.
            int expected = 114148;

            // Act.
            int actual = calculation.GetQuantityForProduct(3, 1, 15, 20, 45);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductTypeEasy_ReturnsNegativeOne()
        {
            // Arrange.
            int expected = -1;

            // Act.
            int actual = calculation.GetQuantityForProduct(0, 1, 15, 20, 45);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialTypeEasy_ReturnsNegativeOne()
        {
            // Arrange.
            int expected = -1;

            // Act.
            int actual = calculation.GetQuantityForProduct(1, 0, 15, 20, 45);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeCountEasy_ReturnsNegativeOne()
        {
            // Arrange.
            int expected = -1;

            // Act.
            int actual = calculation.GetQuantityForProduct(1, 1, -1, 20, 45);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeWidthEasy_ReturnsNegativeOne()
        {
            // Arrange.
            int expected = -1;

            // Act.
            int actual = calculation.GetQuantityForProduct(1, 1, 1, -5, 45);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeLengthEasy_ReturnsNegativeOne()
        {
            // Arrange.
            int expected = -1;

            // Act.
            int actual = calculation.GetQuantityForProduct(1, 1, 1, 5, -45);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeLengthAndWidthEasy_ReturnsNegativeOne()
        {
            // Arrange.
            int expected = -1;

            // Act.
            int actual = calculation.GetQuantityForProduct(1, 1, 1, -5, -45);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_ZeroWidth_ReturnsNegativeOne()
        {
            // Arrange.
            int expected = -1;

            // Act.
            int actual = calculation.GetQuantityForProduct(1, 1, 1, 0, 45);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_ZeroLength_ReturnsNegativeOne()
        {
            // Arrange.
            int expected = -1;

            // Act.
            int actual = calculation.GetQuantityForProduct(1, 1, 1, 1, 0);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetQuantityForProduct_ZeroCount_ReturnsNegativeOne()
        {
            // Arrange.
            int expected = -1;

            // Act.
            int actual = calculation.GetQuantityForProduct(1, 1, 0, 1, 1);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

    }
}
