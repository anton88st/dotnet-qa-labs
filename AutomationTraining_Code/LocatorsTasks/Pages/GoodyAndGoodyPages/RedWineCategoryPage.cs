using OpenQA.Selenium;

namespace LocatorsTasks.Pages.GoodyAndGoodyPages
{
    internal class RedWineCategoryPage
    {
        private readonly IWebDriver driver;

        public RedWineCategoryPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        /*
         * Enter xpath for the following web elements. You should change the word 'xpath' to correct xpath.
         * Web page Url: https://www.goodygoody.com/red-wine/category/redWine
         */

        #region Filter's dropdowns
        private const string FiltersLocator = "//*[@id='filters']";
        private const string FilterButtonLocator = $"{FiltersLocator}//button[text()='{{0}}']";
        private IWebElement WineTypeDropDown => driver.FindElement(By.XPath(string.Format(FilterButtonLocator, "Wine Type")));
        private IWebElement PriceDropDown => driver.FindElement(By.XPath(string.Format(FilterButtonLocator, "Price")));
        private IWebElement CountryDropDown => driver.FindElement(By.XPath(string.Format(FilterButtonLocator, "Country")));
        private IWebElement BrandDropDown => driver.FindElement(By.XPath(string.Format(FilterButtonLocator, "Brand")));
        #endregion

        #region Price's selectors
        private IWebElement ZeroToNineSelector => driver.FindElement(By.XPath(GetPriceSelector("$0 - $9.99")));
        private IWebElement TenToNineteenSelector => driver.FindElement(By.XPath(GetPriceSelector("$10 - $19.99")));
        private IWebElement TwentyToTwentyNineSelector => driver.FindElement(By.XPath(GetPriceSelector("$20 - $29.99")));

        private static string GetPriceSelector(string range) => 
            $"{string.Format(FilterButtonLocator, "Price")}[not(contains(@class,'collapsed'))]/following-sibling::div//*[@title='{range}']";
        #endregion

        #region Country checkboxes
        private const string CountryLocator = ".//*[not(contains(@class,'collapsed'))]/following-sibling::div//li[.//span[text()='{0}']]";
        private IWebElement FranceCheckbox => CountryDropDown.FindElement(By.XPath(string.Format(CountryLocator, "France")));
        private IWebElement ItalyCheckBox => CountryDropDown.FindElement(By.XPath(string.Format(CountryLocator, "Italy")));
        private IWebElement SpainCheckBox => CountryDropDown.FindElement(By.XPath(string.Format(CountryLocator, "Spain")));
        private IWebElement ArgentinaCheckBox => CountryDropDown.FindElement(By.XPath(string.Format(CountryLocator, "Argentina")));
        #endregion

        #region Table elements
        private const string ProductGridLocator = "//*[@id='product-grid']//*[@class='prod_thumbnail']";
        private IWebElement FirstProductElement => driver.FindElement(By.XPath($"({ProductGridLocator})[1]"));
        private IWebElement ThirdProductElement => driver.FindElement(By.XPath($"({ProductGridLocator})[3]"));
        private IWebElement LastProductElement => driver.FindElement(By.XPath($"({ProductGridLocator})[last()]"));
        private IWebElement OutOfStockProduct => driver.FindElement(By.XPath($"{ProductGridLocator}[.//*[@class='product-not-available']]"));
        private IWebElement AddToCartForSpecificProductButton => 
            driver.FindElement(By.XPath($"{ProductGridLocator}[.//*[@class='product_name'] and .//*[text()='Bota Box Merlot']]//button[text()='Add to cart']"));
        private IWebElement ProductPriceElement => driver.FindElement(By.XPath($"{ProductGridLocator}//*[@class='bottle_price']"));
        private IWebElement ProductQuantityTextBox => driver.FindElement(By.XPath($"{ProductGridLocator}//*[@class='quantity']"));
        private IWebElement OnSaleBadgeElement => driver.FindElement(By.XPath($"{ProductGridLocator}//*[contains(@class,'prod-badge')]"));
        #endregion
    }
}