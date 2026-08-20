namespace ToDoListApplication.Printers;

public interface IPrinter
{
    void PrintHello() => Console.WriteLine("Hello");
    void PrintMenu();
    
    void PrintNoToDos();
}