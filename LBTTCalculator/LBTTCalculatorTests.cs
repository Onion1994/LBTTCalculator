using NUnit.Framework;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LBTTCalculator
{
    [TestFixture]
    public class LBTTCalculatorTests
    {
        private LBTTCalculator lbttCalculator;
        [SetUp]
        public void Setup()
        {
            lbttCalculator = new LBTTCalculator();
        }

        [Test]
        public void WhenPropertyIsBelowTresholdShouldReturnZero()
        {
            // Arrange
            decimal price = 100000;
            

            // Act
            decimal tax = lbttCalculator.CalculateTax(price);

            // Assert
            Assert.That(tax, Is.EqualTo(0), "Tax should be zero for properties below the threshold.");
        }
        [Test]
        public void TaxShouldBeRoundedDown()
        {
            // Arrange
            decimal price = 145045;


            // Act
            decimal tax = lbttCalculator.CalculateTax(price);

            // Assert
            Assert.That(tax, Is.EqualTo(0), "Should round down to zero for tax below £1");
        }
        [Test]
        public void WhenPropertyIsAbove145000ShouldReturnTwoPercentTax()
        {
            // Arrange
            decimal price = 200000;;


            // Act
            decimal tax = lbttCalculator.CalculateTax(price);

            // Assert
            Assert.That(tax, Is.EqualTo(1100), "Should add 2% of tax on the amount above the treshold.");
        }
        
        [Test]
        public void WhenPropertyIsAbove250000ShouldReturnFivePercentTax()
        {
            // Arrange
            decimal price = 300000;


            // Act
            decimal tax = lbttCalculator.CalculateTax(price);

            // Assert
            Assert.That(tax, Is.EqualTo(4600), "Should add 5% tax on the amount above 250000 to the total amount");
        }
        [Test]
        public void WhenPropertyIsAbove325000ShouldReturnTenPercentTax()
        {
            // Arrange
            decimal price = 400000;

            // Act
            decimal tax = lbttCalculator.CalculateTax(price);

            // Assert
            Assert.That(tax, Is.EqualTo(13350), "Should add 10% tax on the amount above 325000 to the total amount");
        }
        [Test]
        public void WhenPropertyIsAbove750000ShouldReturnTwelvePercentTax()
        {
            // Arrange
            decimal price = 800000;

            // Act
            decimal tax = lbttCalculator.CalculateTax(price);

            // Assert
            Assert.That(tax, Is.EqualTo(54350), "Should add 12% tax on the amount above 750000 to the total amount");
        }
    }
}