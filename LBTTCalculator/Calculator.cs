using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class Calculator
    {
        public decimal tax;
        public decimal totalAmount;
        public decimal taxedAmount;

        public decimal CalculateTax(decimal price, decimal remainingAmount, decimal taxPercentage, decimal remainingTax)
        {
            taxedAmount = price - remainingAmount;
            tax = taxedAmount * taxPercentage;
            totalAmount = Math.Floor(tax + remainingTax);
            return totalAmount;
        }
    }
}
