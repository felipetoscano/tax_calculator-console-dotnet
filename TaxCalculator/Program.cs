using TaxCalculator.Taxes;

namespace TaxCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var budget = new Budget(1000);
            budget.AddItem(new Item("A", 50));
            budget.AddItem(new Item("B", 50));
            budget.AddItem(new Item("B", 10));

            var t1 = new ICPP();
            var t2 = new IKCV();
            var t3 = new IHIT();

            Console.WriteLine(t1.Calculate(budget));
            Console.WriteLine(t2.Calculate(budget));
            Console.WriteLine(t3.Calculate(budget));
        }
    }
}
