namespace TaxCalculator.Taxes
{
    public class ICCC : TaxTemplate
    {
        public ICCC() : base()
        {

        }

        public ICCC(TaxTemplate nextTax) : base(nextTax)
        {

        }

        public override double Calculate(Budget budget)
        {
            double taxValue;
            if (budget.Value > 3000)
            {
                taxValue = budget.Value * 0.08 + 30;
            }
            else if (budget.Value >= 1000)
            {
                taxValue = budget.Value * 0.07;
            }
            else
            {
                taxValue = budget.Value * 0.05;
            }

            return taxValue + CalculateNextTax(budget);
        }
    }
}
