using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class TenPercentBand : TaxBand
    {
        private const decimal taxPercentage = 0.10m;
        private const decimal LowerBandLimit = 325000;
        private const decimal remainingTax = 5850;
        public decimal InvokeCalculator(decimal price)
        {
            Calculator calculator = new Calculator();
            decimal tax = calculator.CalculateTax(price, LowerBandLimit, taxPercentage, remainingTax);
            return tax;
        }

    }
}
