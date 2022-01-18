namespace TaxCalculator.Taxes
{
    public class ICMS : TaxTemplate
    {
        public ICMS() : base()
        {

        }

        public ICMS(TaxTemplate nextTax) : base(nextTax)
        {

        }

        public override double Calculate(Budget budget)
        {
            return budget.Value * 0.05 + CalculateNextTax(budget);
        }
    }
}
