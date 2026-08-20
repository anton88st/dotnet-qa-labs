using ToDoListApplication.Constants;
using ToDoListApplication.ListRepositories;
using ToDoListApplication.Printers;

namespace ToDoListApplication.App;

public class Application(IPrinter printer, IListRepository listRepository)
{
    private readonly ToDoManager _toDoManager = new(printer, listRepository.GetList());

    public void Start()
    {
        printer.PrintHello();
        var shouldExit = false;
        do
        {
            printer.PrintMenu();
            var input = Console.ReadLine();
            if (input is not null && Enum.TryParse(input.ToUpperInvariant(), out Options userOption))
            {
                shouldExit = _toDoManager.SelectRequiredOption(userOption);
            }
            else
            {
                Console.WriteLine("Invalid option format.");
            }
        }
        while (!shouldExit);
    }
}