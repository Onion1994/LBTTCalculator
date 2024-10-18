using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTTCalculator
{
    internal interface TaxBand
    {
        public decimal InvokeCalculator(decimal price);
    }
}
