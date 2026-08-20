using SharePointTestSuiteTask.Pages;

namespace SharePointTestSuiteTask.Tests
{
    public class Tests : BaseTest
    {
        [Test]
        public async Task CreateLibraryViaApiAndCheckOnUI()
        {
            var libraryName = $"Library_{Guid.NewGuid()}";
            await _graphHelper.CreateLibraryAsync(libraryName);
            GenericPages.MainPage.ClickSiteContent();
            var isLibraryExists = GenericPages.MainPage.Grid.IsLibraryExists(libraryName);
            Assert.That(isLibraryExists, Is.True);
        }
    }
}