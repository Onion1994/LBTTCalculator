using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal class FactoryLBTTCalculator
    {
        public ILBTTCalculator GetTaxCalculator(decimal price)
        {
            if (price <= 145000)
            {
                return new ZeroPercentBandCalculator();
            }
            if (price <= 250000)
            {
                return new TwoPercentBandCalculator();
            }
            if (price <= 325000)
            {
                return new FivePercentBandCalculator();
            }
            if (price <= 750000)
            {
                return new TenPercentBandCalculator();
            }
            return new TwelvePercentBandCalculator();
        }
    }
}
