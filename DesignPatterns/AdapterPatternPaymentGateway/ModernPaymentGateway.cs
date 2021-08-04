using System;

namespace AdapterPatternPaymentGateway
{
    public class ModernPaymentGateway
    {
        public void Transfer(double amount)
        {
            Console.WriteLine($"Transferring {amount} through Modern payment gateway");
        }
    }
}