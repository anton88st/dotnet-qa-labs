using AMDTestSuiteTask.Common.Web;

namespace AMDTestSuiteTask.Tests
{
    [TestFixture]
    internal class BaseTest
    {
        [OneTimeSetUp]
        public void OneTImeSetUp()
        {
            WebDriverFactory.InitializeDriver();
        }

        [OneTimeTearDown]
        public void OneTImeTearDown()
        {
            WebDriverFactory.QuitBrowser();
        }
    }
}
