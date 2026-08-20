namespace SharePointTestSuiteTask.Common.Api.Graph
{
    public class AzureAppCredentials(string? clientId, string? tenantId, string? secret)
    {
        public string? ClientId { get; set; } = clientId;
        public string? TenantId { get; set; } = tenantId;
        public string? Secret { get; set; } = secret;

        public static AzureAppCredentials SharePointAzureAppCredentials => new(
            TestSettingsContainer.TestSettings.SharePointClientId,
            TestSettingsContainer.TestSettings.SharePointTenantId,
            TestSettingsContainer.TestSettings.SharePointAppSecret);
    }
}
