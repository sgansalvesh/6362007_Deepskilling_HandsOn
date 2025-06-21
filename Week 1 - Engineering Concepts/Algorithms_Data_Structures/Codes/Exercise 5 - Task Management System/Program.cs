using System;

public class Task
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public string Status { get; set; }

    public Task(int id, string name, string status)
    {
        TaskId = id;
        TaskName = name;
        Status = status;
    }
}

public class Node
{
    public Task Data;
    public Node Next;

    public Node(Task task)
    {
        Data = task;
        Next = null;
    }
}

public class TaskManager
{
    private Node head;

    public void AddTask()
    {
        Console.Write("Enter Task ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter Task Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Task Status: ");
        string status = Console.ReadLine();

        Task newTask = new Task(id, name, status);
        Node newNode = new Node(newTask);

        if (head == null)
            head = newNode;
        else
        {
            Node temp = head;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = newNode;
        }

        Console.WriteLine("Task Added.");
    }

    public void SearchTask()
    {
        Console.Write("Enter Task ID to search: ");
        int id = int.Parse(Console.ReadLine());
        Node temp = head;

        while (temp != null)
        {
            if (temp.Data.TaskId == id)
            {
                Console.WriteLine("Found: " + temp.Data.TaskName + " - " + temp.Data.Status);
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Task Not Found.");
    }

    public void TraverseTasks()
    {
        Node temp = head;
        if (temp == null)
        {
            Console.WriteLine("No Tasks Available.");
            return;
        }

        while (temp != null)
        {
            Console.WriteLine(temp.Data.TaskId + " " + temp.Data.TaskName + " " + temp.Data.Status);
            temp = temp.Next;
        }
    }

    public void DeleteTask()
    {
        Console.Write("Enter Task ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        if (head == null)
        {
            Console.WriteLine("No Tasks to Delete.");
            return;
        }

        if (head.Data.TaskId == id)
        {
            head = head.Next;
            Console.WriteLine("Task Deleted.");
            return;
        }

        Node prev = head;
        Node curr = head.Next;

        while (curr != null)
        {
            if (curr.Data.TaskId == id)
            {
                prev.Next = curr.Next;
                Console.WriteLine("Task Deleted.");
                return;
            }
            prev = curr;
            curr = curr.Next;
        }

        Console.WriteLine("Task Not Found.");
    }

    public void ShowTimeComplexities()
    {
        Console.WriteLine("Add: O(n)");
        Console.WriteLine("Search: O(n)");
        Console.WriteLine("Traverse: O(n)");
        Console.WriteLine("Delete: O(n)");
        Console.WriteLine("Linked List Advantage: Dynamic size, efficient insert/delete without shifting.");
    }
}

public class Program
{
    public static void Main()
    {
        TaskManager manager = new TaskManager();

        while (true)
        {
            Console.WriteLine("\n1. Add Task");
            Console.WriteLine("2. Search Task");
            Console.WriteLine("3. Traverse Tasks");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Show Time Complexities");
            Console.WriteLine("6. Exit");
            Console.Write("Choose Option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.AddTask();
                    break;
                case 2:
                    manager.SearchTask();
                    break;
                case 3:
                    manager.TraverseTasks();
                    break;
                case 4:
                    manager.DeleteTask();
                    break;
                case 5:
                    manager.ShowTimeComplexities();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }
        }
    }
}
