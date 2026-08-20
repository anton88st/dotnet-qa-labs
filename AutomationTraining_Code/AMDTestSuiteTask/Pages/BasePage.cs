using AMDTestSuiteTask.Common.Web;
using OpenQA.Selenium;

namespace AMDTestSuiteTask.Pages
{
    public class BasePage
    {
        protected static IWebDriver Driver => WebDriverFactory.Driver;
    }
}
