using System;
using System.Collections.Generic;

public class InventoryManager
{
    private Dictionary<int, Product> inventory = new Dictionary<int, Product>();

    public void AddProduct(Product product)
    {
        inventory[product.ProductId] = product;
    }

    public void UpdateProduct(int productId, int quantity, double price)
    {
        if (inventory.ContainsKey(productId))
        {
            inventory[productId].Quantity = quantity;
            inventory[productId].Price = price;
        }
    }

    public void DeleteProduct(int productId)
    {
        inventory.Remove(productId);
    }

    public void DisplayInventory()
    {
        foreach (var product in inventory.Values)
        {
            Console.WriteLine(product);
        }
    }
}
