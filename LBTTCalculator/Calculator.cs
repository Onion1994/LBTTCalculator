using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class Calculator
    {
        public decimal Tax { get; private set; }
        public decimal TotalAmount { get; private set; }
        public decimal TaxedAmount { get; private set; }

        public decimal CalculateTax(decimal price, decimal lowerBandLimit, decimal taxPercentage, decimal remainingTax)
        {
            TaxedAmount = price - lowerBandLimit;
            Tax = TaxedAmount * taxPercentage;
            TotalAmount = Math.Floor(Tax + remainingTax);
            return TotalAmount;
        }
    }
}
