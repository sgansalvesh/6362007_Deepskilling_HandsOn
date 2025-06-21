using System;
using System.Collections.Generic;

namespace ObserverPatternExample
{
    public interface IObserver
    {
        void Update(string stock, double price);
    }

    public interface IStock
    {
        void Register(IObserver observer);
        void Deregister(IObserver observer);
        void Notify(string stock, double price);
    }

    public class StockMarket : IStock
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Deregister(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string stock, double price)
        {
            foreach (var observer in observers)
            {
                observer.Update(stock, price);
            }
        }

        public void SetPrice(string stock, double price)
        {
            Console.WriteLine($"\nPrice updated: {stock} = {price}");
            Notify(stock, price);
        }
    }

    public class MobileApp : IObserver
    {
        public void Update(string stock, double price)
        {
            Console.WriteLine($"[MobileApp] {stock} updated to {price}");
        }
    }

    public class WebApp : IObserver
    {
        public void Update(string stock, double price)
        {
            Console.WriteLine($"[WebApp] {stock} updated to {price}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StockMarket market = new StockMarket();

            IObserver mobileApp = new MobileApp();
            IObserver webApp = new WebApp();

            market.Register(mobileApp);
            market.Register(webApp);

            market.SetPrice("AAPL", 187.50);
            market.SetPrice("GOOGL", 2730.10);

            market.Deregister(webApp);

            market.SetPrice("AAPL", 190.00);
        }
    }
}
