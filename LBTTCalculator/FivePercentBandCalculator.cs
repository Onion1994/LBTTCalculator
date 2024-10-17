using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class FivePercentBandCalculator : ILBTTCalculator
    {
        public decimal taxPercentage = 0.05m;
        public decimal remainingTax = 2100;
        public decimal remainingAmount = 250000;
        public decimal InvokeCalculator(decimal price)
        {
            Calculator calculator = new Calculator();
            decimal tax = calculator.CalculateTax(price, remainingAmount, taxPercentage, remainingTax);
            return tax;
        }
    }
}
