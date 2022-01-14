using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class Budget
    {
        public double Value { get; private set; }

        public Budget(double value)
        {
            Value = value;
        }
    }
}
