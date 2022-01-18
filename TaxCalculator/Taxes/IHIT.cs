namespace TaxCalculator.Taxes
{
    public class IHIT : TaxTemplate
    {
        public IHIT()
        {

        }

        protected override double MaxRate(Budget budget)
        {
            return budget.Value * 0.13 + 100;
        }

        protected override double MinRate(Budget budget)
        {
            return budget.Value * 0.01 * budget.Itens.Count;
        }

        protected override bool ShouldUseMaxRate(Budget budget)
        {
            foreach (var itemI in budget.Itens)
            {
                var counter = 0;
                foreach (var itemJ in budget.Itens)
                {
                    if (itemJ.Name == itemI.Name)
                    {
                        counter++;
                    }
                }
                if (counter > 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
