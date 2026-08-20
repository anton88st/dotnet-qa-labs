namespace LINQTasks_answers.Collections
{
    public static class DatesTimesCollection
    {
        public static readonly List<DateTime> dates = new()
        {
            DateTime.Parse("1999/12/31"),
            DateTime.Today,
            DateTime.Parse("2000/12/31"),
            DateTime.Parse("2005/6/30"),
            DateTime.Parse("2010/4/5"),
            DateTime.Parse("2012/3/15"),
            DateTime.Parse("2005/11/23")
        };

        public static readonly List<DateTime> noDateNow = new()
        {
            DateTime.Parse("1999/12/31"),
            DateTime.Parse("2000/12/30"),
            DateTime.Parse("2005/6/18"),
            DateTime.Parse("2010/6/4"),
            DateTime.Parse("2012/9/15"),
            DateTime.Parse("2005/7/23")
        };
    }
}
