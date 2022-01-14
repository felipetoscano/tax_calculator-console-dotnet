using TaxCalculator.Taxes;

namespace TaxCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var budget = new Budget(500);

            var t1 = new ICCC();
            var t2 = new ICMS();
            var t3 = new ISS();

            var processor = new TaxProcessor();

            processor.Calculate(budget, t1);
            processor.Calculate(budget, t2);
            processor.Calculate(budget, t3);
        }
    }
}
