namespace LINQTasks_answers.Collections
{
    public static class StringsCollections
    {
        public static readonly List<string> Words = new() { "Laptop", "GT", "nvidia", "AI", "Mouse", "schedule", "Fridge", "" };
        public static readonly List<string> ValidWords = new() { "Killer", "Quad", "Razer" };
        public static readonly List<string> WordsWithIndexes = new() { "1.Laptop", "6.GT", "3.nvidia", "AI", "Mouse", "6.schedule", "Fridge", "" };
        public static string UserInfo = "1, User1, user1@gmail.com; 2, User2, user2@microsoft.com; 3, User3, user3@microsoft.com";
        public static List<string> Marks = new() { "Mazda", "BMW" };
        public static List<string> Models = new() { "3", "5" };
        public static List<string> ExpectedMarksModelsCollection = new() { "Mazda 3", "Mazda 5", "BMW 3", "BMW 5" };
    }
}
