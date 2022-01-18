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

            Console.WriteLine(t1.Calculate(budget));
            Console.WriteLine(t2.Calculate(budget));
        }
    }
}
