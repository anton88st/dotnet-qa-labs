using AMDTestSuiteTask.Pages;

namespace AMDTestSuiteTask.Tests
{
    internal class AMDTests : BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            GenericPages.AmdMainPage.OpenPage();
        }

        [Test]
        public void MainPageCheck()
        {
            var expectedItemsCount = 4;
            var expectedSocialMediaCount = 7;

            var isProductDropDownDisplayed = GenericPages.AmdMainPage.IsProductDropDownDisplayed();
            var isSolutionsDropDownDisplayed = GenericPages.AmdMainPage.IsSolutionsDropDownDisplayed();
            var isResourceAndSupportDropDownDisplayed = GenericPages.AmdMainPage.IsResourceAndSupportDropDownDisplayed();
            var isShopDropDownDisplayed = GenericPages.AmdMainPage.IsShopDropDownDisplayed();
            var isSignInOutDropDownDisplayed = GenericPages.AmdMainPage.IsSignInOutDropDownDisplayed();
            var isLanguageDropDownDisplayed = GenericPages.AmdMainPage.IsLanguageDropDownDisplayed();
            var isSearchDropDownDisplayed = GenericPages.AmdMainPage.IsSearchDropDownDisplayed();
            var isShoppingCartDropDownDisplayed = GenericPages.AmdMainPage.IsShoppingCartDropDownDisplayed();
            var actualTrackingInformationBullets = GenericPages.AmdMainPage.GetTrackingInformationBulletsCount();
            var actualLatestNewsItems = GenericPages.AmdMainPage.GetLatestNewsCollectionCount();
            var actualLatestNewsDates = GenericPages.AmdMainPage.GetLatestNewsDates();
            var actualSocialMediaCount = GenericPages.AmdMainPage.GetSocialMediaCount();

            Assert.Multiple(() =>
            {
                Assert.That(isProductDropDownDisplayed, Is.True);
                Assert.That(isSolutionsDropDownDisplayed, Is.True);
                Assert.That(isResourceAndSupportDropDownDisplayed, Is.True);
                Assert.That(isShopDropDownDisplayed, Is.True);
                Assert.That(isSignInOutDropDownDisplayed, Is.True);
                Assert.That(isSearchDropDownDisplayed, Is.True);
                Assert.That(isShoppingCartDropDownDisplayed, Is.True);
                Assert.That(isLanguageDropDownDisplayed, Is.True);
                Assert.That(actualTrackingInformationBullets, Is.EqualTo(expectedItemsCount));
                Assert.That(actualLatestNewsItems, Is.EqualTo(expectedItemsCount));
                Assert.That(actualSocialMediaCount, Is.EqualTo(expectedSocialMediaCount));
                Assert.That(actualLatestNewsDates, Is.EqualTo(actualLatestNewsDates.OrderDescending().ToList()));
            });
        }
    }
}