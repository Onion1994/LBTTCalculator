using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class ZeroPercentBandCalculator : ILBTTCalculator
    {
        public decimal remainingTax = 0;
        public decimal remainingAmount = 0;
        public decimal taxPercentage = 0;
        public decimal InvokeCalculator(decimal price)
        {
            Calculator calculator = new Calculator();
            decimal tax = calculator.CalculateTax(price, remainingAmount, taxPercentage, remainingTax);
            return tax;
        }
    }
}
