using System;

class Program
{
    static void Main(string[] args)
    {
        InventoryManager manager = new InventoryManager();

        while (true)
        {
            Console.WriteLine("\n Inventory Management Menu ");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Update Product");
            Console.WriteLine("3. Delete Product");
            Console.WriteLine("4. Display Inventory");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Product ID: ");
                    int idAdd = int.Parse(Console.ReadLine());
                    Console.Write("Enter Product Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Quantity: ");
                    int qtyAdd = int.Parse(Console.ReadLine());
                    Console.Write("Enter Price: ");
                    double priceAdd = double.Parse(Console.ReadLine());

                    manager.AddProduct(new Product(idAdd, name, qtyAdd, priceAdd));
                    break;

                case "2":
                    Console.Write("Enter Product ID to update: ");
                    int idUpdate = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Quantity: ");
                    int qtyUpdate = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Price: ");
                    double priceUpdate = double.Parse(Console.ReadLine());

                    manager.UpdateProduct(idUpdate, qtyUpdate, priceUpdate);
                    break;

                case "3":
                    Console.Write("Enter Product ID to delete: ");
                    int idDelete = int.Parse(Console.ReadLine());
                    manager.DeleteProduct(idDelete);
                    break;

                case "4":
                    manager.DisplayInventory();
                    break;

                case "5":
                    Console.WriteLine("Exiting... Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
