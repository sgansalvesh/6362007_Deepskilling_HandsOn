using System;

namespace AdapterPatternExample
{
    
    public interface IPaymentProcessor
    {
        void ProcessPayment(string amount);
    }

    
    public class PayPalGateway
    {
        public void MakePayment(string money)
        {
            Console.WriteLine($"[PayPal] Payment of {money} processed.");
        }
    }

    public class StripeGateway
    {
        public void SendPayment(string cash)
        {
            Console.WriteLine($"[Stripe] Payment of {cash} processed.");
        }
    }

    
    public class PayPalAdapter : IPaymentProcessor
    {
        private PayPalGateway _paypal = new PayPalGateway();

        public void ProcessPayment(string amount)
        {
            _paypal.MakePayment(amount);
        }
    }

    public class StripeAdapter : IPaymentProcessor
    {
        private StripeGateway _stripe = new StripeGateway();

        public void ProcessPayment(string amount)
        {
            _stripe.SendPayment(amount);
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor paypal = new PayPalAdapter();
            paypal.ProcessPayment("$100");

            IPaymentProcessor stripe = new StripeAdapter();
            stripe.ProcessPayment("$200");
        }
    }
}
