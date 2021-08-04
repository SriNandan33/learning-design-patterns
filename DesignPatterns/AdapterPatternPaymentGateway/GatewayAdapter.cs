namespace AdapterPatternPaymentGateway
{
    public class GatewayAdapter: IPaymentGateway
    {
        private readonly ModernPaymentGateway _paymentGateway;

        public GatewayAdapter(ModernPaymentGateway paymentGateway)
        {
            _paymentGateway = paymentGateway;
        }
        public void Pay(double amount)
        {
            _paymentGateway.Transfer(amount);
        }
    }
}