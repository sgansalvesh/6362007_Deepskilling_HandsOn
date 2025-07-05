using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


// Insert Data Code 


//class Program
//{
//    static async Task Main()
//    {
//        using var context = new AppDbContext();

//        var electronics = new Category { Name = "Electronics" };
//        var groceries = new Category { Name = "Groceries" };

//        await context.Categories.AddRangeAsync(electronics, groceries);

//        var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
//        var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

//        await context.Products.AddRangeAsync(product1, product2);
//        await context.SaveChangesAsync();

//        Console.WriteLine("Data inserted successfully.");
//    }
//}


class Program
{
    static async Task Main()
    {
        using var context = new AppDbContext();

        // Get All Products
        var products = await context.Products.ToListAsync();
        Console.WriteLine("All Products:");
        foreach (var p in products)
            Console.WriteLine($"{p.Name} - ₹{p.Price}");

        // Find by ID
        var product = await context.Products.FindAsync(1);
        Console.WriteLine($"\nFound: {product?.Name}");

        // FirstOrDefault with condition
        var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
        Console.WriteLine($"\nExpensive: {expensive?.Name}");
    }
}

