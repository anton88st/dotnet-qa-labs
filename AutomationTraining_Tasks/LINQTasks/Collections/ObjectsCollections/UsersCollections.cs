namespace LINQTasks_answers.Collections.ObjectsCollections
{
    public static class UsersCollections
    {
        public static User Adam = new User(12, "Adam");
        public static User Elen = new User(4, "Elen");
        public static User Elgy = new User(2, "Elgy");
        public static User Olga = new User(6, "Olga", "Olga123", "123");
        public static User Petr = new User(8, "Petr", "new", "qwerty");
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public User(int id, string name, string? email = null, string? password = null)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
