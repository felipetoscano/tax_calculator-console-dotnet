using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class TaxProcessor
    {
        public void Calculate(Budget budget, ITax tax)
        {
            var result = tax.Calculate(budget);
            Console.WriteLine(result);
        }
    }
}
