using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SharePointTestSuiteTask.Common;

namespace SharePointTestSuiteTask.Common.Web.Extensions;

public static class WebDriverExtension
{
    private static readonly TimeSpan DefaultPollingInterval = TimeSpan.FromMilliseconds(200);
    private static readonly TimeSpan Timeout = TimeSpan.FromMilliseconds(TestSettingsContainer.TestSettings.Timeout);

    public static WebDriverWait GetWait(this IWebDriver driver,
        TimeSpan timeout = default,
        TimeSpan pollingInterval = default,
        Type[]? exceptionTypes = null)
    {
        var wait = new WebDriverWait(driver, timeout.Ticks == 0 ? Timeout : timeout)
        {
            PollingInterval = pollingInterval.Ticks == 0 ? DefaultPollingInterval : pollingInterval,
        };

        wait.IgnoreExceptionTypes(exceptionTypes ?? new[] { typeof(StaleElementReferenceException) });

        return wait;
    }
}
