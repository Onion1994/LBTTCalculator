using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class LBTTBandSelector
    {
        private readonly List<(decimal upperLimit, Func<ITaxBand> band)> _taxBands;
        public decimal Tax { get; private set; }

        public LBTTBandSelector()
        {
            _taxBands = new List<(decimal, Func<ITaxBand>)>
        {
            (145000, () => new ZeroPercentBand()),
            (250000, () => new TwoPercentBand()),
            (325000, () => new FivePercentBand()),
            (750000, () => new TenPercentBand()),
            (decimal.MaxValue, () => new TwelvePercentBand())
        };
        }

        public ITaxBand SelectBand(decimal price)
        {
            return _taxBands.First(band => price <= band.upperLimit).band();
        }
    }
}
