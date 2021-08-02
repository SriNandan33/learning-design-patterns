using System;

namespace StrategyPatternPayments.PaymentStrategies
{
    public class ValetStrategy: IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paying {amount} through your favourite Valet app");
        }
    }
}