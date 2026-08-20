using System.Drawing;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SharePointTestSuiteTask.Common;

namespace SharePointTestSuiteTask.Common.Web.Extensions;

public static class WebElementExtension
{
    private static readonly TimeSpan Timeout = TimeSpan.FromMilliseconds(TestSettingsContainer.TestSettings.Timeout);

    public static IWebElement GetWebElementIfExists(this IWebDriver driver, By by)
    {
        IWebElement? element = null;

        void FindElement()
        {
            var wait = new WebDriverWait(driver, Timeout);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(TargetInvocationException), typeof(InvalidOperationException));
            Point? previousLocation = null;
            wait.Until(drv =>
            {
                var currentElement = drv.FindElements(by).FirstOrDefault();
                if (currentElement == null)
                {
                    return false;
                }

                var currentLocation = currentElement.Location;
                var isStable = previousLocation == currentLocation;
                previousLocation = currentLocation;

                return isStable;
            });
            element = driver.FindElement(by);
        }

        try
        {
            FindElement();
        }
        catch (WebDriverTimeoutException exception)
        {
            throw new Exception($"The element with {by} locator was not found during the timeout - {Timeout}\n{exception.InnerException?.Message}");
        }

        return element!;
    }
}
