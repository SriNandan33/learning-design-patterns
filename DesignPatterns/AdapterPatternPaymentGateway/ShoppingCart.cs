using System;
using System.Collections.Generic;
using System.Linq;

namespace AdapterPatternPaymentGateway
{
    public class ShoppingCart
    {
        private IPaymentGateway PaymentGateway { get; set; }
        private readonly List<Item> _items = new();

        public ShoppingCart(IPaymentGateway paymentGateway)
        {
            PaymentGateway = paymentGateway;
        }

        public void AddItem(Item item)
        {
            Console.WriteLine($"Adding \"{item.Code}\" to cart");
            _items.Add(item);
        }

        public void Checkout()
        {
            Console.WriteLine("Checking out...");
            var totalAmount = _items.Sum(item => item.Price);
            PaymentGateway.Pay(totalAmount);
            ClearCart();
        }

        private void ClearCart()
        {
            _items.Clear();
        }
    }
}