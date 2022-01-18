using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Taxes
{
    public abstract class TaxTemplate
    {
        public TaxTemplate NextTax { get; private set; }
        public TaxTemplate(TaxTemplate nextTax)
        {
            NextTax = nextTax;
        }

        public TaxTemplate()
        {
            NextTax = null;
        }

        public abstract double Calculate(Budget budget);

        public double CalculateNextTax(Budget budget)
        {
            if(NextTax == null)
            {
                return 0;
            }

            return NextTax.Calculate(budget);
        }
    }
}
