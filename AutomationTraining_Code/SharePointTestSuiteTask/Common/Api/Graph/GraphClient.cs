using System.Collections.Concurrent;
using Azure.Identity;
using Microsoft.Graph;
using SharePointTestSuiteTask.Common;

namespace SharePointTestSuiteTask.Common.Api.Graph
{
    public static class GraphClient
    {
        private static readonly ConcurrentDictionary<string, GraphServiceClient> ClientCollection = new ConcurrentDictionary<string, GraphServiceClient>();

        public static GraphServiceClient GetClient()
        {
            if (!ClientCollection.ContainsKey(TestSettingsContainer.TestSettings.AzureAppClientId))
            {
                InitializeClient();
            }

            return ClientCollection[TestSettingsContainer.TestSettings.AzureAppClientId];
        }

        private static void InitializeClient()
        {
            var clientSecretCredentials = new ClientSecretCredential(
                TestSettingsContainer.TestSettings.AzureAppTenantId,
                TestSettingsContainer.TestSettings.AzureAppClientId,
                TestSettingsContainer.TestSettings.AzureAppSecret);

            var client = new GraphServiceClient(clientSecretCredentials, new[] { "https://graph.microsoft.com/.default" });

            ClientCollection.TryAdd(TestSettingsContainer.TestSettings.AzureAppClientId, client);
        }
    }
}
