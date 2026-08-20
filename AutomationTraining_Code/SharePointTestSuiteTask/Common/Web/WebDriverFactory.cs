using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using SharePointTestSuiteTask.Common;

namespace SharePointTestSuiteTask.Common.Web;

internal class WebDriverFactory
{
    public static IWebDriver Driver { get; set; }

    public static void InitializeDriver()
    {
        switch (TestSettingsContainer.TestSettings.Browser)
        {
            case Browser.Chrome:
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--window-size=1300,1000");
                var chromeDriver = new ChromeDriver(chromeOptions);
                Driver = chromeDriver;
                break;
            case Browser.Firefox:
                var firefoxOptions = new FirefoxOptions();
                firefoxOptions.AddArgument("--window-size=1300,1000");
                var firefoxDriver = new FirefoxDriver(firefoxOptions);
                Driver = firefoxDriver;
                break;
            case Browser.Edge:
                var edgeOptions = new EdgeOptions();
                edgeOptions.AddArgument("--window-size=1300,1000");
                var edgeDriver = new EdgeDriver(edgeOptions);
                Driver = edgeDriver;
                break;
            default:
                throw new Exception("Browser is not supported");
        }
    }

    public static void QuitBrowser()
    {
        Driver?.Close();
        Driver?.Quit();
        Driver?.Dispose();
    }
}
