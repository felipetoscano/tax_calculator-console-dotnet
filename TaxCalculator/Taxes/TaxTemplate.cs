namespace TaxCalculator.Taxes
{
    public abstract class TaxTemplate
    {
        public double Calculate(Budget budget)
        {
            if (ShouldUseMaxRate(budget))
            {
                return MaxRate(budget);
            }
            else
            {
                return MinRate(budget);
            }
        }

        protected abstract bool ShouldUseMaxRate(Budget budget);
        protected abstract double MaxRate(Budget budget);
        protected abstract double MinRate(Budget budget);
    }
}
