using Microsoft.Extensions.Configuration;

namespace SharePointTestSuiteTask.Common;

public class TestSettings
{
    public IConfiguration TestConfiguration => new ConfigurationBuilder()
        .AddJsonFile("settings.json")
        .AddJsonFile("settings.local.json", optional: true)
        .Build();

    public TestSettings()
    {
        SetValues();
    }

    public Browser Browser { get; set; }
    public int Timeout { get; set; }
    public string AzureAppClientId { get; set; }
    public string AzureAppTenantId { get; set; }
    public string AzureAppSecret { get; set; }
    public string SharePointClientId { get; set; }
    public string SharePointTenantId { get; set; }
    public string SharePointAppSecret { get; set; }
    public string MicrosoftAdminEmail { get; set; }
    public string MicrosoftAdminPassword { get; set; }
    public string SharePointSite { get; set; }

    private void SetValues()
    {
        Enum.TryParse(TestConfiguration["Browser"], out Browser browser);
        Browser = browser;
        Timeout = TryParseIntValue(TestConfiguration["Timeout"]);
        SharePointClientId = TestConfiguration["Graph:ClientId"];
        SharePointTenantId = TestConfiguration["Graph:TenantId"];
        SharePointAppSecret = TestConfiguration["Graph:Secret"];
        MicrosoftAdminEmail = TestConfiguration["Graph:AdminEmail"];
        MicrosoftAdminPassword = TestConfiguration["Graph:AdminPassword"];
        SharePointSite = TestConfiguration["Graph:SharePointSite"];
    }

    private int TryParseIntValue(string? value)
    {
        int.TryParse((string)value, out var result);

        return result;
    }
}

public enum Browser
{
    Chrome,
    Edge,
    Firefox
}
