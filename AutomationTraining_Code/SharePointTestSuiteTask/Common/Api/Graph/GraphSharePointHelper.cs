using System.Text.RegularExpressions;
using Microsoft.Graph.Models;
using SharePointTestSuiteTask.Common;
using SharePointTestSuiteTask.Common.Api;

namespace SharePointTestSuiteTask.Common.Api.Graph
{
    public class GraphSharePointHelper
    {
        private string SiteId { get; set; } = string.Empty;

        public GraphSharePointHelper()
        {
            ApiConfigurationHelper.OverrideAzureAppCredentials(AzureAppCredentials.SharePointAzureAppCredentials);
        }

        public async Task InitializeAsync()
        {
            SiteId = await SetSiteIdAsync();
        }

        public async Task CreateLibraryAsync(string libraryName)
        {
            var requestBody = new Microsoft.Graph.Models.List
            {
                DisplayName = libraryName,
                ListProp = new ListInfo
                {
                    Template = "documentLibrary"
                }
            };
            await GraphClient.GetClient().Sites[SiteId].Lists.PostAsync(requestBody);
        }

        private async Task<string> SetSiteIdAsync()
        {
            var siteName = GetSiteNameFromSettings();
            var result = await GraphClient.GetClient().Sites.GetAllSites.GetAsync(requestConfiguration =>
            {
                requestConfiguration.QueryParameters.Filter = $"displayName eq '{siteName}'";
            });
            var resultId = result?.Value?.FirstOrDefault()?.Id;

            return ExtractSiteId(resultId);
        }

        private string GetSiteNameFromSettings()
        {
            var pattern = @"<required patter>";
            var siteName = Regex.Replace(TestSettingsContainer.TestSettings.SharePointSite, pattern, "");

            return siteName;
        }

        private string ExtractSiteId(string? fullSiteId)
        {
            if (string.IsNullOrEmpty(fullSiteId))
            {
                throw new InvalidOperationException(
                    $"SharePoint site '{GetSiteNameFromSettings()}' was not found via Graph — cannot extract site id.");
            }

            var removeString = @"<required patter>";

            return Regex.Replace(fullSiteId, removeString, "");
        }
    }
}
