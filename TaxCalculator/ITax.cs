using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public interface ITax
    {
        public double Calculate(Budget budget);
    }
}
