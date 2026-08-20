namespace LINQTasks_answers.Collections.ObjectsCollections
{
    public static class StudentsCollections
    {
        public static List<Student> Students = new()
        {
            new Student(1, "Andrew", new List<int> {5, 6, 8, 1, 9, 7}),
            new Student(2, "Olga", new List<int> { 0, 2, 8, 9, 9, 7 }),
            new Student(3, "Algerd", new List<int>{5, 6, 7, 8, 7, 8}),
            new Student(4, "Elen", new List<int>()),
            new Student(5, "Piotr", new List<int> { 9, 9, 9, 8, 8, 7}),
            new Student(6, "Sam", new List<int>())
        };
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> Marks { get; set; }

        public Student(int id, string name, List<int> marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
        }
    }
}
