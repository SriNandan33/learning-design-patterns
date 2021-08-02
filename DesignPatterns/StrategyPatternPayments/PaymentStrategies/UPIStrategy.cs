using System;

namespace StrategyPatternPayments.PaymentStrategies
{
    public class UPIStrategy: IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paying {amount} through you favorite UPI app");
        }
    }
}