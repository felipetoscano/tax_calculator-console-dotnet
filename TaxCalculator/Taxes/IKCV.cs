namespace TaxCalculator.Taxes
{
    public class IKCV : TaxTemplate
    {
        public IKCV()
        {

        }

        protected override double MaxRate(Budget budget)
        {
            return budget.Value * 0.1;
        }

        protected override double MinRate(Budget budget)
        {
            return budget.Value * 0.06;
        }

        protected override bool ShouldUseMaxRate(Budget budget)
        {
            return budget.Value > 500 && HasValueGreaterThan100(budget);
        }

        private static bool HasValueGreaterThan100(Budget budget)
        {
            foreach (var item in budget.Itens)
            {
                if (item.Value > 100)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
