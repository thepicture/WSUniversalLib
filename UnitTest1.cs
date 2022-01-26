using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WSUniversalLib
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void GetQuantityForProduct_ValidParams_ReturnsInteger()
        {
            // Arrange.
            Calculation calculation = new Calculation();
            int expected = 114148;

            // Act.
            int actual = calculation.GetQuantityForProduct(3, 1, 15, 20, 45);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
    }
}
