using ToDoListApplication.Constants;
using ToDoListApplication.Printers;

namespace ToDoListApplication.App;

public class ToDoManager(IPrinter printer, List<string> toDosList)
{
    public bool SelectRequiredOption(Options userChoice)
    {
        switch (userChoice)
        {
            case Options.S:
                SeeAllToDos();
                break;
            case Options.A:
                AddNewToDo();
                break;
            case Options.R:
                RemoveToDo();
                break;
            case Options.E:
                return true;
            default:
                Console.WriteLine("Invalid choice.\r\n");
                break;
        }

        return false;
    }

    private void SeeAllToDos()
    {
        Console.WriteLine();
        if (toDosList.Count == 0)
        {
            printer.PrintNoToDos();
            return;
        }

        for (var i = 0; i < toDosList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {toDosList[i]}");
        }
    }

    private void AddNewToDo()
    {
        string? description;
        do
        {
            Console.WriteLine("Enter the TODO description:");
            description = Console.ReadLine();
        }
        while (!IsDescriptionValid(description));

        toDosList.Add(description!);
        Console.WriteLine($"\r\nTODO successfully added: {description}");
    }

    private void RemoveToDo()
    {
        if (toDosList.Count == 0)
        {
            printer.PrintNoToDos();
            return;
        }

        int index;
        do
        {
            Console.WriteLine("Select the index of the TODO you want to remove:");
            SeeAllToDos();
        }
        while (!TryReadIndex(out index));

        RemoveToDoAtIndex(index);
    }

    private bool IsDescriptionValid(string? description)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            Console.WriteLine("The description cannot be empty.");
            return false;
        }

        if (toDosList.Contains(description))
        {
            Console.WriteLine("The description must be unique.\r\n");
            return false;
        }

        return true;
    }

    private void RemoveToDoAtIndex(int index)
    {
        Console.WriteLine($"TODO removed: {toDosList[index - 1]}");
        toDosList.RemoveAt(index - 1);
    }

    private bool TryReadIndex(out int index)
    {
        var userIndex = Console.ReadLine();
        if (string.IsNullOrEmpty(userIndex))
        {
            index = 0;
            Console.WriteLine("Selected index cannot be empty.");
            return false;
        }

        if (int.TryParse(userIndex, out index) && index >= 1 && toDosList.Count >= index)
        {
            return true;
        }

        Console.WriteLine("The given index is not valid.\r\n");
        return false;
    }
}
