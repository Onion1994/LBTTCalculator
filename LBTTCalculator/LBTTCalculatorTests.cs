using NUnit.Framework;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LBTTCalculator
{
    [TestFixture]
    public class LBTTCalculatorTests
    {
        private FactoryLBTTCalculator calculatorFactory;
        [SetUp]
        public void Setup()
        {
            calculatorFactory = new FactoryLBTTCalculator();
        }

        [Test]
        public void WhenPropertyIsBelowTresholdShouldReturnZero()
        {
            // Arrange
            decimal price = 100000;
            ILBTTCalculator calculator = calculatorFactory.GetTaxCalculator(price);
            

            // Act
            decimal tax = calculator.InvokeCalculator(price);

            // Assert
            Assert.That(tax, Is.EqualTo(0), "Tax should be zero for properties below the threshold.");
        }
        [Test]
        public void TaxShouldBeRoundedDown()
        {
            // Arrange
            decimal price = 145045;
            ILBTTCalculator calculator = calculatorFactory.GetTaxCalculator(price);


            // Act
            decimal tax = calculator.InvokeCalculator(price);

            // Assert
            Assert.That(tax, Is.EqualTo(0), "Should round down to zero for tax below £1");
        }
        [Test]
        public void WhenPropertyIsAbove145000ShouldReturnTwoPercentTax()
        {
            // Arrange
            decimal price = 200000;
            ILBTTCalculator calculator = calculatorFactory.GetTaxCalculator(price);


            // Act
            decimal tax = calculator.InvokeCalculator(price);

            // Assert
            Assert.That(tax, Is.EqualTo(1100), "Should add 2% of tax on the amount above the treshold.");
        }
        
        [Test]
        public void WhenPropertyIsAbove250000ShouldReturnFivePercentTax()
        {
            // Arrange
            decimal price = 300000;
            ILBTTCalculator calculator = calculatorFactory.GetTaxCalculator(price);


            // Act
            decimal tax = calculator.InvokeCalculator(price);

            // Assert
            Assert.That(tax, Is.EqualTo(4600), "Should add 5% tax on the amount above 250000 to the total amount");
        }
        [Test]
        public void WhenPropertyIsAbove325000ShouldReturnTenPercentTax()
        {
            // Arrange
            decimal price = 400000;
            ILBTTCalculator calculator = calculatorFactory.GetTaxCalculator(price);


            // Act
            decimal tax = calculator.InvokeCalculator(price);

            // Assert
            Assert.That(tax, Is.EqualTo(13350), "Should add 10% tax on the amount above 325000 to the total amount");
        }
        [Test]
        public void WhenPropertyIsAbove750000ShouldReturnTwelvePercentTax()
        {
            // Arrange
            decimal price = 800000;
            ILBTTCalculator calculator = calculatorFactory.GetTaxCalculator(price);


            // Act
            decimal tax = calculator.InvokeCalculator(price);

            // Assert
            Assert.That(tax, Is.EqualTo(54350), "Should add 12% tax on the amount above 750000 to the total amount");
        }
    }
}