namespace ToDoListApplication.ListRepositories;

public class ClassRepository : IListRepository
{
    private List<string> _list = [];
    
    public List<string> GetList() => _list;
    
    public void SaveList(List<string> list) => _list = list;
}