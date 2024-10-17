using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class TwelvePercentBandCalculator : ILBTTCalculator
    {
        public decimal taxPercentage = 0.12m;
        public decimal remainingAmount = 750000;
        public decimal remainingTax = 48350;
        public decimal InvokeCalculator(decimal price)
        {
            Calculator calculator = new Calculator();
            decimal tax = calculator.CalculateTax(price, remainingAmount, taxPercentage, remainingTax);
            return tax;
        }

    }
}
