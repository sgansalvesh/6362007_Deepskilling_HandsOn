using System;

namespace DecoratorPatternExample
{
    
    public interface INotifier
    {
        void Send(string message);
    }

    
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"[Email] {message}");
        }
    }

    
    public abstract class NotifierDecorator : INotifier
    {
        protected INotifier _wrappee;

        protected NotifierDecorator(INotifier notifier)
        {
            _wrappee = notifier;
        }

        public virtual void Send(string message)
        {
            _wrappee.Send(message);
        }
    }

    
    public class SMSNotifierDecorator : NotifierDecorator
    {
        public SMSNotifierDecorator(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"[SMS] {message}");
        }
    }

    public class SlackNotifierDecorator : NotifierDecorator
    {
        public SlackNotifierDecorator(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"[Slack] {message}");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            // Base notifier
            INotifier notifier = new EmailNotifier();

            // Add SMS and Slack via decorators
            notifier = new SMSNotifierDecorator(notifier);
            notifier = new SlackNotifierDecorator(notifier);

            notifier.Send("System update at 6 PM.");
        }
    }
}
