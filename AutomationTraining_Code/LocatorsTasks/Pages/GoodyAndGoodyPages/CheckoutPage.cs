using OpenQA.Selenium;

namespace LocatorsTasks.Pages.GoodyAndGoodyPages
{
    internal class CheckoutPage
    {
        private readonly IWebDriver driver;

        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        /*
         * Enter xpath for the following web elements. You should change the word 'xpath' to correct xpath.
         * Web page Url: https://www.goodygoody.com/checkout
         */

        #region Pickup or Delivery radio buttons
        private const string RadioButton = "//*[contains(@id,'OrderNotes')]//div[contains(@class,'store')]//label[contains(text(),'{0}')]/preceding-sibling::div";
        private IWebElement DeliveryRadioButton => driver.FindElement(By.XPath(string.Format(RadioButton, "Delivery")));
        private IWebElement InStorePickupRadioButton => driver.FindElement(By.XPath(string.Format(RadioButton, "In Store Pickup")));
        #endregion

        #region Order Summary elements
        private const string OrderSummaryContainer = "//*[@id='CC-checkoutOrderSummary']";
        private IWebElement SubTotalRowElement => driver.FindElement(By.XPath($"{OrderSummaryContainer}//*[@class='row'][.//*[contains(text(),'Sub-Total:')]]"));
        private IWebElement DeliveryRowElement => driver.FindElement(By.XPath($"{OrderSummaryContainer}//*[@class='row'][.//*[contains(text(),'Delivery')]]"));
        private IWebElement SalesTaxRowElement => driver.FindElement(By.XPath($"{OrderSummaryContainer}//*[@id='CC-checkoutOrderSummary-salesTax' and .//*[contains(text(),'Sales Tax')]]"));
        #endregion

        #region CartSummary elements
        private const string CheckoutSummaryContainer = "//*[@id='checkoutCartSummary']";
        private IWebElement QuantityElement => driver.FindElement(By.XPath($"{CheckoutSummaryContainer}//*[@class='quantity-wrap']"));
        private IWebElement ItemTotalElement => driver.FindElement(By.XPath($"({CheckoutSummaryContainer}//*[@class='price_total'])[1]"));
        private IWebElement RemoveIcon => driver.FindElement(By.XPath($"{CheckoutSummaryContainer}//*[@class='remove-btn']"));
        private IWebElement InStockElement => driver.FindElement(By.XPath($"{CheckoutSummaryContainer}//*[@class='stock_msg']"));
        #endregion
    }
}
