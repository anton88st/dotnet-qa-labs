using System.Collections.Concurrent;

namespace SharePointTestSuiteTask.Common
{
    public class TestSettingsContainer
    {
        private static readonly ConcurrentDictionary<string, TestSettings> TestSettignsCollection= new ConcurrentDictionary<string, TestSettings>();

        public static TestSettings TestSettings
        {
            get
            {
                TestSettignsCollection.TryAdd(TestContext.CurrentContext.Test.ClassName, new TestSettings());

                return TestSettignsCollection.First(pair => pair.Key == TestContext.CurrentContext.Test.ClassName).Value;
            }
        }

        public static void RemoveTestSettings() => TestSettignsCollection.TryRemove(TestContext.CurrentContext.Test.ClassName, out _);
    }
}
