using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class LBTTBandSelector
    {
        private readonly List<ITaxBand> _taxBands;
        public decimal Tax { get; private set; }

        TaxBand TwoPercentBand = new TaxBand(0.02m, 145000, 0);
        TaxBand FivePercentBand = new TaxBand(0.05m, 250000, 2100);
        TaxBand TenPercentBand = new TaxBand(0.10m, 325000, 5850);
        TaxBand TwelvePercentBand = new TaxBand(0.12m, 750000, 48350);

        public LBTTBandSelector()
        {
            _taxBands = new List<ITaxBand>
        {
            TwoPercentBand, FivePercentBand, TenPercentBand, TwelvePercentBand,
        };
        }

        public decimal SelectBand(decimal price)
        {
            if (price < TwoPercentBand.lowerBandLimit)
            {
                return 0;
            }

            return _taxBands.Last(band => ((TaxBand)band).lowerBandLimit <= price).CalculateTaxDue(price);
        }
    }
}
