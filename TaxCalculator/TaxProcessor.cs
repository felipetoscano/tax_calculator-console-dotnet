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
