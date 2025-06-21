using System;

namespace StrategyPatternExample
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }
    }

    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal.");
        }
    }

    public class PaymentContext
    {
        private IPaymentStrategy _strategy;

        public PaymentContext(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void MakePayment(decimal amount)
        {
            _strategy.Pay(amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PaymentContext context = new PaymentContext(new CreditCardPayment());
            context.MakePayment(500);

            context.SetStrategy(new PayPalPayment());
            context.MakePayment(300);
        }
    }
}
