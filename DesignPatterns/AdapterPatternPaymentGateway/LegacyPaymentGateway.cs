using System;

namespace AdapterPatternPaymentGateway
{
    public class LegacyPaymentGateway: IPaymentGateway
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paying {amount} through legacy payment gateway");
        }
    }
}