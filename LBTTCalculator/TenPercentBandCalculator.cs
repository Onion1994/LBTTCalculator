using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class TenPercentBandCalculator : ILBTTCalculator
    {
        public decimal taxPercentage = 0.10m;
        public decimal remainingAmount = 325000;
        public decimal remainingTax = 5850;
        public decimal InvokeCalculator(decimal price)
        {
            Calculator calculator = new Calculator();
            decimal tax = calculator.CalculateTax(price, remainingAmount, taxPercentage, remainingTax);
            return tax;
        }

    }
}
