using System;

public class FinancialForecast
{
    public static double PredictFutureValue(double initialValue, double growthRate, int years)
    {
        if (years == 0)
            return initialValue;
        return PredictFutureValue(initialValue, growthRate, years - 1) * (1 + growthRate);
    }

    public static double PredictFutureValueMemo(double initialValue, double growthRate, int years, double[] memo)
    {
        if (years == 0)
            return initialValue;
        if (memo[years] != 0)
            return memo[years];

        memo[years] = PredictFutureValueMemo(initialValue, growthRate, years - 1, memo) * (1 + growthRate);
        return memo[years];
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter Initial Value: ");
        double initialValue = double.Parse(Console.ReadLine());

        Console.Write("Enter Annual Growth Rate (e.g., 0.05 for 5%): ");
        double growthRate = double.Parse(Console.ReadLine());

        Console.Write("Enter Number of Years: ");
        int years = int.Parse(Console.ReadLine());

        double result = FinancialForecast.PredictFutureValue(initialValue, growthRate, years);
        Console.WriteLine("Future Value (Recursive): " + result);

        double[] memo = new double[years + 1];
        double resultMemo = FinancialForecast.PredictFutureValueMemo(initialValue, growthRate, years, memo);
        Console.WriteLine("Future Value (Memoized): " + resultMemo);

        Console.WriteLine("\nTime Complexity:");
        Console.WriteLine("Recursive: O(n)");
        Console.WriteLine("Memoized: O(n) with reduced redundant calls");
        Console.WriteLine("Optimization: Use memoization to cache intermediate results and avoid recomputation.");
    }
}
