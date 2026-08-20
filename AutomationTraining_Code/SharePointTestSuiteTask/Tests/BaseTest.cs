using SharePointTestSuiteTask.Common;
using SharePointTestSuiteTask.Common.Api.Graph;
using SharePointTestSuiteTask.Common.Web;
using SharePointTestSuiteTask.Pages;

namespace SharePointTestSuiteTask.Tests;

[TestFixture]
public class BaseTest
{
    private readonly string Url;
    protected GraphSharePointHelper _graphHelper = null!;

    public BaseTest(string url = null)
    {
        Url = url ?? TestSettingsContainer.TestSettings.SharePointSite;
    }

    [OneTimeSetUp]
    public async Task OneTimeSetUp()
    {
        _graphHelper = new GraphSharePointHelper();
        await _graphHelper.InitializeAsync();

        WebDriverFactory.InitializeDriver();
        WebDriverFactory.Driver.Navigate().GoToUrl(Url);
        GenericPages.MicrosoftLoginPage.LoginToMIcrosoftOnline(TestSettingsContainer.TestSettings.MicrosoftAdminEmail, TestSettingsContainer.TestSettings.MicrosoftAdminPassword);
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        WebDriverFactory.QuitBrowser();
    }
}
