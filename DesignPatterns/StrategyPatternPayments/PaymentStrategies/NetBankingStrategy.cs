using System;

namespace StrategyPatternPayments.PaymentStrategies
{
    public class NetBankingStrategy: IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paying {amount} through NetBanking");
        }
    }
}