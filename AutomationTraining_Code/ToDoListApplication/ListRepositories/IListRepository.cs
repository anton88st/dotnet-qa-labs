namespace ToDoListApplication.ListRepositories;

public interface IListRepository
{
    List<string> GetList();
    
    void SaveList(List<string> list) => Console.WriteLine("List can be saved only in file.");
}