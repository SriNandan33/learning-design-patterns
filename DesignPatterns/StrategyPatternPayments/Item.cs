namespace StrategyPatternPayments
{
    public class Item
    {
        public string Code { get; }
        public double Price { get; }

        public Item(string code, double price)
        {
            Code = code;
            Price = price;
        }
    }
}