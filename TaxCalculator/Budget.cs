namespace TaxCalculator
{
    public class Budget
    {
        public double Value { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Budget(double value)
        {
            Value = value;
            Itens = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
