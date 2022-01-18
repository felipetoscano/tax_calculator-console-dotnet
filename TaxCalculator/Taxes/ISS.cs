namespace TaxCalculator.Taxes
{
    public class ISS : TaxTemplate
    {
        public ISS() : base()
        {

        }

        public ISS(TaxTemplate nextTax) : base(nextTax) 
        {

        } 

        public override double Calculate(Budget budget)
        {
            return budget.Value * 0.06 + CalculateNextTax(budget);
        }
    }
}
