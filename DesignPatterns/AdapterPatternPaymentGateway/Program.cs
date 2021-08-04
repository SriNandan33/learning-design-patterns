using System;

namespace AdapterPatternPaymentGateway
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Shopping Cart Simulator\n");

            IPaymentGateway paymentGateway = new LegacyPaymentGateway();
            var cart = new ShoppingCart(paymentGateway);
            
            AddDummyItemsToCart(cart);
            cart.Checkout();
            
            // Modern payment gateway
            paymentGateway = new GatewayAdapter(new ModernPaymentGateway());
            cart = new ShoppingCart(paymentGateway);
            
            AddDummyItemsToCart(cart);
            cart.Checkout();
        }

        private static void AddDummyItemsToCart(ShoppingCart cart)
        {
            cart.AddItem(new Item("Head first design patterns", 1200));
            cart.AddItem(new Item("Design Patterns: GOF", 999));
        }
    }
}