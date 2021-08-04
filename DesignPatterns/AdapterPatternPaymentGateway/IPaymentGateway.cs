namespace AdapterPatternPaymentGateway
{
    public interface IPaymentGateway
    {
        void Pay(double amount);
    }
}