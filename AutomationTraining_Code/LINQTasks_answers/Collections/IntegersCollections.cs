namespace LINQTasks_answers.Collections
{
    public static class IntegersCollections
    {
        public static readonly List<int> numberWithoutPositive = new() { -1, -5, -1, -9 };
        public static readonly List<int> numbersWithPositive = new() { 1, 0, -1, -4, -5, 7, 3, 5, 6 };
        public static readonly List<int> evenNumbers = new() { 2, 4, 6, -4 };
        public static readonly List<List<int>> NestedNumbersLists = new()
        {
            new List<int> { 1, -1, 2, 3 },
            new List<int> { 1 },
            new List<int> { 1, 0, 8 },
            new List<int> { 1, 4, 7, 8 }
        };
    }
}
