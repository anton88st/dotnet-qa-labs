using Microsoft.Extensions.Configuration;

namespace AMDTestSuiteTask.Common;

public class TestSettings
{
    private static IConfiguration TestConfiguration => new ConfigurationBuilder()
        .AddJsonFile("settings.json")
        .AddJsonFile("settings.local.json", optional: true)
        .Build();

    public TestSettings()
    {
        SetValues();
    }

    public Browser Browser { get; set; }
    public int Timeout { get; set; }
    public string? AmdMainPageUrl { get; set; }

    private void SetValues()
    {
        Enum.TryParse(TestConfiguration["Browser"], out Browser browser);
        Browser = browser;
        Timeout = TryParseIntValue(TestConfiguration["Timeout"]);
        AmdMainPageUrl = TestConfiguration["AMDMainPageUrl"];
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

