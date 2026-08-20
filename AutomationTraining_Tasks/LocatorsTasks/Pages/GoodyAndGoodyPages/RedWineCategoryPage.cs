using OpenQA.Selenium;

namespace LocatorsTasks.Pages.GoodyAndGoodyPages
{
    internal class RedWineCategoryPage
    {
        private WebDriver driver;
        /*
         * Enter xpath for the following web elements. You should change the phrase 'enter xpath here' to correct xpath.
         * Web page Url: https://www.goodygoody.com/red-wine/category/redWine
         */

        #region Filter's dropdowns
        private IWebElement WineTypeDropDown => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement PriceDropDown => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement CountryDropDown => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement BrandDropDown => driver.FindElement(By.XPath("enter xpath here"));
        #endregion

        #region Price's selectors
        private IWebElement ZeroToNineSelector => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement TenToNineteenSelector => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement TwentyToTwentyNineSelector => driver.FindElement(By.XPath("enter xpath here"));
        #endregion

        #region Country checkboxes
        private IWebElement FranceChecbox => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement ItalyCheckBox => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement SpainCheckBox => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement ArgentinaCheckBox => driver.FindElement(By.XPath("enter xpath here"));
        #endregion

        #region Table elements
        private IWebElement FirstProductElement => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement ThirdProductElement => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement LastProductElement => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement OutOfStockProduct => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement AddTOCartForSpecificProductButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement ProductPriceElement => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement ProductQuantityTextBox => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement OnSaleBadgeElement => driver.FindElement(By.XPath("enter xpath here"));
        #endregion
    }
}
