using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Test_Division()
        {
            // Arrange
            int expectedQuotient = 5;
            int numerator = 20;
            int denominator = 4;

            // Act
            int quotient = Calculator.Library.Calculator.Divide(numerator, denominator);

            // Assert
            Assert.AreEqual(quotient, expectedQuotient);
        }
    }
}
