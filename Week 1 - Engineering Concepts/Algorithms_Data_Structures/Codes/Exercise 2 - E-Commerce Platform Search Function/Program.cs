using System;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

public class SearchFunction
{
    public static int LinearSearch(Product[] products, string name)
    {
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].ProductName == name)
                return i;
        }
        return -1;
    }

    public static int BinarySearch(Product[] products, string name)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int cmp = string.Compare(products[mid].ProductName, name);
            if (cmp == 0)
                return mid;
            else if (cmp < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
}

public class Program
{
    public static void Main()
    {
        Product[] linearProducts = {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Shoes", "Footwear"),
            new Product(3, "Watch", "Accessories")
        };

        Product[] binaryProducts = {
            new Product(3, "Laptop", "Electronics"),
            new Product(2, "Shoes", "Footwear"),
            new Product(1, "Watch", "Accessories")
        };

        Array.Sort(binaryProducts, (a, b) => a.ProductName.CompareTo(b.ProductName));

        int linearResult = SearchFunction.LinearSearch(linearProducts, "Shoes");
        int binaryResult = SearchFunction.BinarySearch(binaryProducts, "Shoes");

        Console.WriteLine("Linear Search Index: " + linearResult);
        Console.WriteLine("Binary Search Index: " + binaryResult);
    }
}
