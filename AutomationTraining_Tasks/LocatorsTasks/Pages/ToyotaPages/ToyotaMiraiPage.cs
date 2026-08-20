using OpenQA.Selenium;

namespace LocatorsTasks.Pages.ToyotaPages
{
    internal class ToyotaMiraiPage
    {
        private WebDriver driver;
        /*
         * Enter xpath for the following web elements. You should change the phrase 'enter xpath here' to correct xpath.
         * Web page Url: https://www.toyota.com/mirai/
         */

        #region Header's buttons
        private IWebElement OverviewButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement GalleryButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement FeaturesButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement MoreDropDown => driver.FindElement(By.XPath("enter xpath here"));
        #endregion

        #region More dropdown selectors
        private IWebElement SpecsSelector => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement CompareSelector => driver.FindElement(By.XPath("enter xpath here"));
        #endregion

        #region Page Elements
        private IWebElement DragToRotateArea => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement BlueColorRadioButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement BlackColorRadioButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement ColorNameTextElement => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement BuildNowButton => driver.FindElement(By.XPath("enter xpath here"));
        #endregion
    }
}
