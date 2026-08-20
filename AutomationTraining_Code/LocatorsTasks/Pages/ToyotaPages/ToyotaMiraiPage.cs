using OpenQA.Selenium;

namespace LocatorsTasks.Pages.ToyotaPages
{
    internal class ToyotaMiraiPage
    {
        private readonly IWebDriver driver;

        public ToyotaMiraiPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /*
         * Enter xpath for the following web elements. You should change the word 'xpath' to correct xpath.
         * Web page Url: https://www.toyota.com/mirai/
         */

        #region Header's buttons
        private const string HeaderButtonLocator =
            "//*[@class='menu-wrap']//*[contains(@class,'menu-item')]//*[contains(text(),'{0}')]";
        private IWebElement OverviewButton => driver.FindElement(By.XPath(string.Format(HeaderButtonLocator, "Overview")));
        private IWebElement GalleryButton => driver.FindElement(By.XPath(string.Format(HeaderButtonLocator, "Gallery")));
        private IWebElement FeaturesButton => driver.FindElement(By.XPath(string.Format(HeaderButtonLocator, "Features")));
        private IWebElement MoreDropDown => driver.FindElement(By.XPath(string.Format(HeaderButtonLocator, "More")));
        #endregion

        #region More dropdown selectors
        private const string MoreDropdownItemLocator =
            "//*[@class='menu-wrap']//*[contains(@class,'menu-item')]//*[.//*[contains(text(),'More')]]//*[contains(text(),'{0}')]";
        private IWebElement SpecsSelector => driver.FindElement(By.XPath(string.Format(MoreDropdownItemLocator, "Specs")));
        private IWebElement CompareSelector => driver.FindElement(By.XPath(string.Format(MoreDropdownItemLocator, "Compare")));
        #endregion

        #region Page Elements
        private IWebElement DragToRotateArea => driver.FindElement(By.XPath("//*[@class='outer-wrap']//*[contains(@id,'colorizer')]//button[@aria-label='DRAG TO ROTATE']"));
        private IWebElement BlueColorRadioButton => driver.FindElement(By.XPath("//*[@class='outer-wrap']//*[contains(@id,'colorizer__color-selector')]//button[@data-color-hex='1347C1']"));
        private IWebElement BlackColorRadioButton => driver.FindElement(By.XPath("//*[@class='outer-wrap']//*[contains(@id,'colorizer__color-selector')]//button[@data-color-hex='000000']"));
        private IWebElement ColorNameTextElement => driver.FindElement(By.XPath("//*[@class='outer-wrap']//*[contains(@id,'colorizer__color-selector')]//*[contains(@class,'color-selector__name')]"));
        private IWebElement BuildNowButton => driver.FindElement(By.XPath("//*[@class='outer-wrap']//*[contains(@class,'colorizer')]//a[.//*[contains(text(),'Build Now')]]"));
        #endregion
    }
}
