using OpenQA.Selenium;

namespace LocatorsTasks.Pages.GoodyAndGoodyPages
{
    internal class CheckoutPage
    {
        private WebDriver driver;
        /*
         * Enter xpath for the following web elements. You should change the phrase 'enter xpath here' to correct xpath.
         * Web page Url: https://www.goodygoody.com/checkout
         */

        #region Pickup or Delivery radio buttons
        private IWebElement DeliveryRadioButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement InStorePickupRadioButton => driver.FindElement(By.XPath("enter xpath here"));
        #endregion

        #region Order Summary elements
        private IWebElement SubTotalRowElement => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement DeliveryRowElement => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement SalesTaxRowElement => driver.FindElement(By.XPath("enter xpath here"));
        #endregion

        #region CartSummary elements
        private IWebElement QuantityElement => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement ItemTotalElement => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement RemoveIcon => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement InStockElement => driver.FindElement(By.XPath("enter xpath here"));
        #endregion
    }
}
