using System;

namespace StrategyPatternPayments.PaymentStrategies
{
    public class CODStrategy: IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine("COD is chosen, so not making payment now");
        }
    }
}