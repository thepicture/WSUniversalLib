using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WSUniversalLib
{
    [TestClass]
    public class CalculationTests
    {
        private static readonly Calculation calculation = new Calculation();

        [TestMethod]
        public void GetQuantityForProduct_ValidParams_ReturnsInteger()
        {
            // Arrange.
            int expected = 114148;

            // Act.
            int actual = calculation.GetQuantityForProduct(3, 1, 15, 20, 45);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
    }
}
