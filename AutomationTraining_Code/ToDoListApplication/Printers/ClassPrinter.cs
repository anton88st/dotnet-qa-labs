namespace ToDoListApplication.Printers;

public class ClassPrinter : IPrinter
{
    public void PrintMenu()
    {
        Console.WriteLine();
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("[S]ee all todos");
        Console.WriteLine("[A]dd a todo");
        Console.WriteLine("[R]emove a todo");
        Console.WriteLine("[E]xit");
    }

    public void PrintNoToDos() => Console.WriteLine("There are no TODOs at all.\r\n");
}