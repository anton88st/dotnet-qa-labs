using SharePointTestSuiteTask.Common.Api.Graph;
using SharePointTestSuiteTask.Common;

namespace SharePointTestSuiteTask.Common.Api
{
    public static class ApiConfigurationHelper
    {
        public static void OverrideAzureAppCredentials(AzureAppCredentials azureAppCredentials)
        {
            TestSettingsContainer.TestSettings.AzureAppClientId = azureAppCredentials.ClientId;
            TestSettingsContainer.TestSettings.AzureAppTenantId = azureAppCredentials.TenantId;
            TestSettingsContainer.TestSettings.AzureAppSecret = azureAppCredentials.Secret;
        }
    }
}
