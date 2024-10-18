using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class TwelvePercentBand : ITaxBand
    {
        private const decimal TaxPercentage = 0.12m;
        private const decimal LowerBandLimit = 750000;
        private const decimal RemainingTax = 48350;
        public decimal InvokeCalculator(decimal price)
        {
            Calculator calculator = new Calculator();
            decimal tax = calculator.CalculateTax(price, LowerBandLimit, TaxPercentage, RemainingTax);
            return tax;
        }

    }
}
