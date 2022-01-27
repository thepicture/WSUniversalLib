using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WSUniversalLib
{
    [TestClass]
    public class CalculationTests
    {
        private static readonly Calculation calculation = new Calculation();

        #region Easy tests

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
        public void GetQuantityForProduct_ZeroWidthEasy_ReturnsNegativeOne()
        {
            // Arrange.
            int expected = -1;

            // Act.
            int actual = calculation.GetQuantityForProduct(1, 1, 1, 0, 45);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_ZeroLengthEasy_ReturnsNegativeOne()
        {
            // Arrange.
            int expected = -1;

            // Act.
            int actual = calculation.GetQuantityForProduct(1, 1, 1, 1, 0);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetQuantityForProduct_ZeroCountEasy_ReturnsNegativeOne()
        {
            // Arrange.
            int expected = -1;

            // Act.
            int actual = calculation.GetQuantityForProduct(1, 1, 0, 1, 1);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        #endregion
        #region Hard tests

        [TestMethod]
        public void GetQuantityForProduct_MetissaWidth_Returns1018()
        {
            int expected = 1018;

            // Act.
            int actual = calculation.GetQuantityForProduct(1, 1, 1, 20.5f, 45);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_MetissaLength_Returns115416()
        {
            int expected = 115416;

            // Act.
            int actual = calculation.GetQuantityForProduct(3, 1, 15, 20, 45.5f);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_MetissaWidthAndLength_Returns118302()
        {
            int expected = 118302;

            // Act.
            int actual = calculation.GetQuantityForProduct(3, 1, 15, 20.5f, 45.5f);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_MetissaWidthAndLengthAndBigNumbers_ReturnsNegativeOne()
        {
            int expected = -1;

            // Act.
            int actual = calculation.GetQuantityForProduct(3, 2, 34534515, 23453450.5f, 452345235.5f);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_BigNumbers_ReturnsNegativeOne()
        {
            int expected = -1;

            // Act.
            int actual = calculation.GetQuantityForProduct(3, 2, 123456, 2345343345450, 452345235);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        #endregion
    }
}
