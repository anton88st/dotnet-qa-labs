using OpenQA.Selenium;

namespace LocatorsTasks.Pages.ToyotaPages
{
    internal class ToyotaMiraiBuildPage
    {
        private WebDriver driver;
        /*
         * Enter xpath for the following web elements. You should change the phrase 'enter xpath here' to correct xpath.
         * Web page Url: https://www.toyota.com/mirai/ -> click 'Build' button -> enter 93023 zip code and set location. 
         * You webPage Url: https://www.toyota.com/configurator/build/step/model/year/2023/series/mirai/?bap_guid=d28a86c4-33c8-47b4-97a1-0228bd3065f1
         */

        #region Your build section elements
        private IWebElement CarTitleTextElement => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement VehicleOverviewButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement PriceTextElement => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement GetQuoteButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement ExteriorRadioButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement NextExteriorRadioButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement InteriorRadioButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement NextInteriorRadioButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement ViewLargerImagesButton => driver.FindElement(By.XPath("enter xpath here"));
        #endregion

        #region Navigation buttons
        private IWebElement ModelsButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement EnginesButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement ColorsButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement PackagesButton => driver.FindElement(By.XPath("enter xpath here"));
        #endregion

        #region Accessories tab elements
        private IWebElement AllButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement InteriorButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement ExteriorButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement AddSpecificAccessoryButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement ViewDetailsAccessoryButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement PriceAccessoryTextElement => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement NameAccessoryTextElement => driver.FindElement(By.XPath("enter xpath here"));
        #endregion
    }
}
