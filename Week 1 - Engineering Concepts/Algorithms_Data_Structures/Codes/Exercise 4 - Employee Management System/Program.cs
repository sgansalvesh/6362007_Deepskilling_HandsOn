using System;

public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, string position, double salary)
    {
        EmployeeId = id;
        Name = name;
        Position = position;
        Salary = salary;
    }
}

public class EmployeeManager
{
    private Employee[] employees;
    private int count;

    public EmployeeManager(int size)
    {
        employees = new Employee[size];
        count = 0;
    }

    public void AddEmployee()
    {
        if (count >= employees.Length)
        {
            Console.WriteLine("Employee list is full.");
            return;
        }

        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Position: ");
        string position = Console.ReadLine();
        Console.Write("Enter Salary: ");
        double salary = double.Parse(Console.ReadLine());

        employees[count] = new Employee(id, name, position, salary);
        count++;
        Console.WriteLine("Employee Added.");
    }

    public void SearchEmployee()
    {
        Console.Write("Enter ID to search: ");
        int id = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
            {
                Console.WriteLine("Found: " + employees[i].Name + " " + employees[i].Position + " " + employees[i].Salary);
                return;
            }
        }
        Console.WriteLine("Employee not found.");
    }

    public void Traverse()
    {
        if (count == 0)
        {
            Console.WriteLine("No employees to display.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(employees[i].EmployeeId + " " + employees[i].Name + " " + employees[i].Position + " " + employees[i].Salary);
        }
    }

    public void DeleteEmployee()
    {
        Console.Write("Enter ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        int index = -1;
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Employee not found.");
            return;
        }

        for (int i = index; i < count - 1; i++)
        {
            employees[i] = employees[i + 1];
        }

        employees[count - 1] = null;
        count--;
        Console.WriteLine("Employee Deleted.");
    }
}

public class Program
{
    public static void Main()
    {
        EmployeeManager manager = new EmployeeManager(100);

        while (true)
        {
            Console.WriteLine("\n1. Add Employee");
            Console.WriteLine("2. Search Employee");
            Console.WriteLine("3. Display All Employees");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Show Time Complexities");
            Console.WriteLine("6. Exit");
            Console.Write("Choose option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.AddEmployee();
                    break;
                case 2:
                    manager.SearchEmployee();
                    break;
                case 3:
                    manager.Traverse();
                    break;
                case 4:
                    manager.DeleteEmployee();
                    break;
                case 5:
                    Console.WriteLine("Add: O(1)");
                    Console.WriteLine("Search: O(n)");
                    Console.WriteLine("Traverse: O(n)");
                    Console.WriteLine("Delete: O(n)");
                    Console.WriteLine("Limitation: Fixed size, not efficient for dynamic insert/delete.");
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
