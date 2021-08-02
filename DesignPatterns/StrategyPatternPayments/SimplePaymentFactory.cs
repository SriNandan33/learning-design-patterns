using System;
using StrategyPatternPayments.PaymentStrategies;

namespace StrategyPatternPayments
{
    public class SimplePaymentFactory
    {
        public IPaymentStrategy ChoosePaymentMethod(PaymentType type)
        {
            return type switch
            {
                PaymentType.Card => new CardStrategy(),
                PaymentType.UPI => new UPIStrategy(),
                PaymentType.Valet => new ValetStrategy(),
                PaymentType.NetBanking => new NetBankingStrategy(),
                PaymentType.COD => new CODStrategy(),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }
    }
}