using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("This is the first log message.");
            logger2.Log("This is the second log message.");

            Console.WriteLine($"logger1 and logger2 are same instance: {object.ReferenceEquals(logger1, logger2)}");
        }
    }
}
