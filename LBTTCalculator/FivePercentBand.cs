using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class FivePercentBand : TaxBand
    {
        private const decimal TaxPercentage = 0.05m;
        private const decimal LowerBandLimit = 250000;
        private const decimal RemainingTax = 2100;
        public decimal InvokeCalculator(decimal price)
        {
            Calculator calculator = new Calculator();
            decimal tax = calculator.CalculateTax(price, LowerBandLimit, TaxPercentage, RemainingTax);
            return tax;
        }
    }
}
