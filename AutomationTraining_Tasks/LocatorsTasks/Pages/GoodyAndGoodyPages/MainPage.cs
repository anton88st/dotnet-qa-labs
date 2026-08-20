using OpenQA.Selenium;

namespace LocatorsTasks.Pages.GoodyAndGoodyPages
{
    internal class MainPage
    {
        private WebDriver driver;
        /*
         * Enter xpath for the following web elements. You should change the phrase 'enter xpath here' to correct xpath.
         * Web page Url: https://www.goodygoody.com/
         */

        #region Section's buttons
        private IWebElement WinoSectionButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement BeerSectionBUtton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement LiquorSectionButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement MixersSectionButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement SnacksAndMoreSectionButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement GiftCardsSectionButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement TopPicksSectionButton => driver.FindElement(By.XPath("enter xpath here"));
        #endregion

        #region Category's buttons
        private IWebElement RedWineCategoryButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement WhiteWineCategoryButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement PorterBeerCategoryButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement JapanBeerCategoryButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement IrishLiquorCategoryButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement CoolersCategoryButton => driver.FindElement(By.XPath("enter xpath here"));
        #endregion

        #region Header Elements
        private IWebElement SearchTextbox => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement SearchButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement SignInButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement CartIcon => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement LogoButton => driver.FindElement(By.XPath("enter xpath here "));
        #endregion
    }
}
