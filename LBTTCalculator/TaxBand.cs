using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class TaxBand : ITaxBand
    {
        public decimal taxPercentage;
        public decimal lowerBandLimit;
        public decimal remainingTax;
        public decimal Tax { get; private set; }
        public decimal TotalAmount { get; private set; }
        public decimal TaxedAmount { get; private set; }
        public TaxBand(decimal taxPercentage, decimal lowerBandLimit, decimal remainingTax) {
            this.taxPercentage = taxPercentage;
            this.lowerBandLimit = lowerBandLimit;
            this.remainingTax = remainingTax;
        }
        public decimal CalculateTaxDue(decimal price) {
            TaxedAmount = price - lowerBandLimit;
            Tax = TaxedAmount * taxPercentage;
            TotalAmount = Math.Floor(Tax + remainingTax);
            return TotalAmount;
        }
    }
}
