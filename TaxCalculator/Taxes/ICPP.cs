namespace TaxCalculator.Taxes
{
    public class ICPP : TaxTemplate
    {
        public ICPP()
        {

        }

        protected override double MaxRate(Budget budget)
        {
            return budget.Value * 0.07;
        }

        protected override double MinRate(Budget budget)
        {
            return budget.Value * 0.05;
        }

        protected override bool ShouldUseMaxRate(Budget budget)
        {
            return budget.Value >= 500;
        }
    }
}
