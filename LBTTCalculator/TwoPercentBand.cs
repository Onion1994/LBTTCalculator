using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class TwoPercentBand : TaxBand
    {
        private const decimal TaxPercentage = 0.02m;
        private const decimal LowerBandLimit = 145000;
        private const decimal RemainingTax = 0;
        public decimal InvokeCalculator(decimal price)
        {
            Calculator calculator = new Calculator();
            decimal tax = calculator.CalculateTax(price, LowerBandLimit, TaxPercentage, RemainingTax);
            return tax;
        }
    }
}
