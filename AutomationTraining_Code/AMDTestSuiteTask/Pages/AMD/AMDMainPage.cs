using AMDTestSuiteTask.Common;
using AMDTestSuiteTask.Common.Web;
using AMDTestSuiteTask.Common.Web.BaseElements;
using AMDTestSuiteTask.Common.Web.Extensions;
using AMDTestSuiteTask.Constants;
using OpenQA.Selenium;
using System.Globalization;

namespace AMDTestSuiteTask.Pages.AMD
{
    public class AmdMainPage : BasePage
    {
        private const string HeaderXpathContainer = "//*[@id='navbarSupportedContent']";
        private const string HeaderIconXpathContainer = "//*[contains(@class,'icon-nav')]";

        private CustomDropDown ProductDropDown => new CustomDropDown(By.XPath($"{HeaderXpathContainer}//*[contains(@class,'nav-item') and ./a[contains(text(),'Products')]]"));
        private CustomDropDown SolutionsDropDown => new CustomDropDown(By.XPath($"{HeaderXpathContainer}//*[contains(@class,'nav-item') and ./a[contains(text(),'Solutions')]]"));
        private CustomDropDown ResourceAndSupportDropDown => new CustomDropDown(By.XPath($"{HeaderXpathContainer}//*[contains(@class,'nav-item') and ./a[contains(text(),'Resources & Support')]]"));
        private CustomDropDown ShopDropDown => new CustomDropDown(By.XPath($"{HeaderXpathContainer}//*[contains(@class,'nav-item') and ./a[contains(text(),'Shop')]]"));
        private CustomDropDown SignInOutDropDown => new CustomDropDown(By.XPath($"{HeaderIconXpathContainer}//*[contains(@class,'icon-item') and ./a[@id='signedOutDropdown']]"));
        private CustomDropDown LanguageDropDown => new CustomDropDown(By.XPath($"{HeaderIconXpathContainer}//*[contains(@class,'icon-item') and ./a[@id='langDropdown']]"));
        private CustomDropDown SearchDropDown => new CustomDropDown(By.XPath($"{HeaderIconXpathContainer}//*[contains(@class,'icon-item') and ./a[@id='searchDropdown']]"));
        private CustomDropDown ShoppingCartDropDown => new CustomDropDown(By.XPath($"{HeaderIconXpathContainer}//*[contains(@class,'icon-item') and .//a[@id='shoppingCart']]"));
        private CustomWebElement TrackingInformationBulletsElement => new CustomWebElement(By.XPath($"//*[contains(@class,'heroCarousel')]//*[contains(@class,'bullets')]"));
        private CustomWebElement LatestNewsContainer => new CustomWebElement(By.XPath($"//*[contains(@class,'container-lg') and .//h2[contains(text(),'Latest News')]]"));
        private CustomWebElement SocialMediaMenu => new CustomWebElement(By.XPath($"//*[@class='social-menu']"));

        public bool IsProductDropDownDisplayed() => ProductDropDown.IsDisplayed();

        public bool IsSolutionsDropDownDisplayed() => SolutionsDropDown.IsDisplayed();

        public bool IsResourceAndSupportDropDownDisplayed() => ResourceAndSupportDropDown.IsDisplayed();

        public bool IsShopDropDownDisplayed() => ShopDropDown.IsDisplayed();

        public bool IsSignInOutDropDownDisplayed() => SignInOutDropDown.IsDisplayed();

        public bool IsLanguageDropDownDisplayed() => LanguageDropDown.IsDisplayed();

        public bool IsSearchDropDownDisplayed() => SearchDropDown.IsDisplayed();

        public bool IsShoppingCartDropDownDisplayed() => ShoppingCartDropDown.IsDisplayed();

        public int GetTrackingInformationBulletsCount() => TrackingInformationBulletsElement.FindElements(By.XPath(".//*[@data-tracking-information]")).Count();

        public int GetLatestNewsCollectionCount() => LatestNewsContainer.FindElements(By.XPath(".//*[@class='col']")).Count();

        public List<DateTime> GetLatestNewsDates()
        {
            var datesFromUI = LatestNewsContainer.FindElements(By.XPath(".//*[@class='card-date']")).Select(element => element.Text).ToList();
            var dates = datesFromUI.Select(date =>
            {
                var convertedDate = DateTime.ParseExact(date, DateTimeFormats.MMMMddCommayyyy, CultureInfo.InvariantCulture);
                return convertedDate;
            });

            return dates.ToList();
        }

        public int GetSocialMediaCount() => SocialMediaMenu.FindElements(By.XPath(".//a[@href]")).Count();

        public void OpenPage() => WebDriverFactory.Driver.OpenTargetUrl(TestSettingsContainer.TestSettings.AmdMainPageUrl);
    }
}
