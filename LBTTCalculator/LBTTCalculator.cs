using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class LBTTCalculator
    {
        private readonly LBTTBandSelector _lbttBandSelector = new LBTTBandSelector();
        public decimal Tax { get; private set; }
        public decimal CalculateTax(decimal price)
        {
            Tax = _lbttBandSelector.SelectBand(price).InvokeCalculator(price);
            return Tax;
        }
    }
}
