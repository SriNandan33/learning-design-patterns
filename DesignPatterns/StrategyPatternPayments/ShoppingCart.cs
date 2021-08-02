using System;
using System.Collections.Generic;
using System.Linq;
using StrategyPatternPayments.PaymentStrategies;

namespace StrategyPatternPayments
{
    public class ShoppingCart
    {
        public IPaymentStrategy PaymentMethod { get; set; }
        private readonly List<Item> _items = new();

        public void AddItem(Item item)
        {
            Console.WriteLine($"Adding \"{item.Code}\" to cart");
            _items.Add(item);
        }

        public void Checkout()
        {
            Console.WriteLine("Checking out...");
            var totalAmount = _items.Sum(item => item.Price);
            PaymentMethod.Pay(totalAmount);
            ClearCart();
        }

        private void ClearCart()
        {
            _items.Clear();
        }
    }
}