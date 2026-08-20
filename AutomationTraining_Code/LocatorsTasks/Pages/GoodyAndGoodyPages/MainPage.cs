using OpenQA.Selenium;

namespace LocatorsTasks.Pages.GoodyAndGoodyPages
{
    internal class MainPage
    {
        private readonly IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        /*
         * Enter xpath for the following web elements. You should change the word 'xpath' to correct xpath.
         * Web page Url: https://www.goodygoody.com/
         */

        #region Section's buttons
        private const string SectionLocator = "//nav[.//*[contains(@class,'nav menu')]]//li[.//*[@title='{0}']]";
        private IWebElement WineSectionButton => driver.FindElement(By.XPath(string.Format(SectionLocator, "Wine")));
        private IWebElement BeerSectionButton => driver.FindElement(By.XPath(string.Format(SectionLocator, "Beer")));
        private IWebElement LiquorSectionButton => driver.FindElement(By.XPath(string.Format(SectionLocator, "Liquor")));
        private IWebElement MixersSectionButton => driver.FindElement(By.XPath(string.Format(SectionLocator, "Mixers")));
        private IWebElement SnacksAndMoreSectionButton => driver.FindElement(By.XPath(string.Format(SectionLocator, "SnacksAndMore")));
        private IWebElement GiftCardsSectionButton => driver.FindElement(By.XPath(string.Format(SectionLocator, "GiftCards")));
        private IWebElement TopPicksSectionButton => driver.FindElement(By.XPath(string.Format(SectionLocator, "TopPicks")));
        #endregion

        #region Category's buttons
        private const string CategoryLocator ="//nav[.//*[contains(@class,'nav menu')]]//li[.//*[@title='{0}']][contains(@class,'mouseenter')]//li[.//*[@title='{1}']]";
        private IWebElement RedWineCategoryButton => driver.FindElement(By.XPath(string.Format(CategoryLocator, "Wine", "Red Wine")));
        private IWebElement WhiteWineCategoryButton => driver.FindElement(By.XPath(string.Format(CategoryLocator, "Wine", "White Wine")));
        private IWebElement PorterBeerCategoryButton => driver.FindElement(By.XPath(string.Format(CategoryLocator, "Beer", "Porter")));
        private IWebElement JapanBeerCategoryButton => driver.FindElement(By.XPath(string.Format(CategoryLocator, "Beer", "Japan Beer")));
        private IWebElement IrishLiquorCategoryButton => driver.FindElement(By.XPath(string.Format(CategoryLocator, "Liquor", "Irish")));
        private IWebElement CoolersCategoryButton => driver.FindElement(By.XPath(string.Format(CategoryLocator, "Liquor", "Coolers")));
        #endregion

        #region Header Elements
        private const string HeaderLocator = "//div[contains(@class,'header-inner')]";
        private IWebElement SearchTextbox => driver.FindElement(By.XPath($"{HeaderLocator}//*[@class='search-box']//input"));
        private IWebElement SearchButton => driver.FindElement(By.XPath($"{HeaderLocator}//*[@class='search-box']//button[@type]"));
        private IWebElement SignInButton => driver.FindElement(By.XPath($"{HeaderLocator}//*[contains(@href,'login') and @class='my-account-link']"));
        private IWebElement CartIcon => driver.FindElement(By.XPath($"{HeaderLocator}//*[@id='new-dropdowncart']"));
        private IWebElement LogoButton => driver.FindElement(By.XPath($"({HeaderLocator}//*[contains(@class,'logo') and @href])[last()]"));
        #endregion
    }
}