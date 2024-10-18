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
        public ITaxBand Band { get; private set; }
        public decimal Tax { get; private set; }
        public decimal CalculateTax(decimal price)
        {
            Band = _lbttBandSelector.SelectBand(price);
            Tax = Band.InvokeCalculator(price);
            return Tax;
        }
    }
}
