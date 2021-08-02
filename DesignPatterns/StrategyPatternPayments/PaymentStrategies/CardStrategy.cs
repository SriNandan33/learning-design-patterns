using System;

namespace StrategyPatternPayments.PaymentStrategies
{
    public class CardStrategy: IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paying {amount} through Credit/Debit Card");
        }
    }
}