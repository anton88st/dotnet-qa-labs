using ToDoListApplication.App;
using ToDoListApplication.ListRepositories;
using ToDoListApplication.Printers;

namespace ToDoListApplication;

internal class Program
{
    private static void Main(string[] args) => new Application(new ClassPrinter(), new ClassRepository()).Start();
}