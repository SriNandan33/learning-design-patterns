using System;

namespace StrategyPatternPayments
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Shopping Cart Simulator\n");

            var cart = new ShoppingCart();
            var paymentFactory = new SimplePaymentFactory();
            
            AddDummyItemsToCart(cart);
            cart.PaymentMethod = paymentFactory.ChoosePaymentMethod(PaymentType.Card);
            cart.Checkout();
            
            AddDummyItemsToCart(cart);
            cart.PaymentMethod = paymentFactory.ChoosePaymentMethod(PaymentType.UPI);
            cart.Checkout();
            
            AddDummyItemsToCart(cart);
            cart.PaymentMethod = paymentFactory.ChoosePaymentMethod(PaymentType.COD);
            cart.Checkout();
        }

        private static void AddDummyItemsToCart(ShoppingCart cart)
        {
            cart.AddItem(new Item("Head first design patterns", 1200));
            cart.AddItem(new Item("Design Patterns: GOF", 999));
        }
    }
}