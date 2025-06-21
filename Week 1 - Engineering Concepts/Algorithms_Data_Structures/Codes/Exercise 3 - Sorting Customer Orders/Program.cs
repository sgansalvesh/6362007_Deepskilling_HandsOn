using System;

public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double TotalPrice { get; set; }

    public Order(int id, string name, double price)
    {
        OrderId = id;
        CustomerName = name;
        TotalPrice = price;
    }
}

public class OrderSorter
{
    public static void BubbleSort(Order[] orders)
    {
        int n = orders.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                {
                    var temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
            }
        }
    }

    public static void QuickSort(Order[] orders, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(orders, low, high);
            QuickSort(orders, low, pi - 1);
            QuickSort(orders, pi + 1, high);
        }
    }

    private static int Partition(Order[] orders, int low, int high)
    {
        double pivot = orders[high].TotalPrice;
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (orders[j].TotalPrice < pivot)
            {
                i++;
                var temp = orders[i];
                orders[i] = orders[j];
                orders[j] = temp;
            }
        }
        var temp1 = orders[i + 1];
        orders[i + 1] = orders[high];
        orders[high] = temp1;
        return i + 1;
    }
}

public class Program
{
    public static void Main()
    {
        Order[] bubbleOrders = {
            new Order(1, "Alice", 500),
            new Order(2, "Bob", 200),
            new Order(3, "Charlie", 800)
        };

        Order[] quickOrders = {
            new Order(1, "Alice", 500),
            new Order(2, "Bob", 200),
            new Order(3, "Charlie", 800)
        };

        OrderSorter.BubbleSort(bubbleOrders);
        OrderSorter.QuickSort(quickOrders, 0, quickOrders.Length - 1);

        Console.WriteLine("Bubble Sort:");
        foreach (var order in bubbleOrders)
            Console.WriteLine(order.OrderId + " " + order.CustomerName + " " + order.TotalPrice);

        Console.WriteLine("Quick Sort:");
        foreach (var order in quickOrders)
            Console.WriteLine(order.OrderId + " " + order.CustomerName + " " + order.TotalPrice);
    }
}
