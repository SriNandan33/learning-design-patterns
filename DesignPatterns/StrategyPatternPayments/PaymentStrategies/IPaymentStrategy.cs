namespace StrategyPatternPayments.PaymentStrategies
{
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }
}