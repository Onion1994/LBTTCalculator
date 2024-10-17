using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class TwoPercentBandCalculator : ILBTTCalculator
    {
        public decimal taxPercentage = 0.02m;
        public decimal remainingAmount = 145000;
        public decimal remainingTax = 0;
        public decimal InvokeCalculator(decimal price)
        {
            Calculator calculator = new Calculator();
            decimal tax = calculator.CalculateTax(price, remainingAmount, taxPercentage, remainingTax);
            return tax;
        }
    }
}
