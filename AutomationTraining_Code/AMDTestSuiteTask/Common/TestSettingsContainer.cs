using System.Collections.Concurrent;

namespace AMDTestSuiteTask.Common
{
    internal class TestSettingsContainer
    {
        private static readonly ConcurrentDictionary<string, TestSettings> TestSettingsCollection = new();

        public static TestSettings TestSettings
        {
            get
            {
                TestSettingsCollection.TryAdd(TestContext.CurrentContext.Test.ClassName, new TestSettings());

                return TestSettingsCollection.First(pair => pair.Key == TestContext.CurrentContext.Test.ClassName).Value;
            }
        }

        public static void RemoveTestSettings() => TestSettingsCollection.TryRemove(TestContext.CurrentContext.Test.ClassName, out _);
    }
}
