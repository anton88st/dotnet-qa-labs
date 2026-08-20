using OpenQA.Selenium;

namespace LocatorsTasks.Pages.ToyotaPages
{
    internal class MainPage
    {
        private WebDriver driver;
        /*
         * Enter xpath for the following web elements. You should change the phrase 'enter xpath here' to correct xpath.
         * Web page Url: https://www.toyota.com/
         */

        #region Header's buttons
        private IWebElement VehiclesDropDown => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement ShoppingToolsDropDown => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement SignInDropDown => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement OwnersDropDown => driver.FindElement(By.XPath("enter xpath here"));
        #endregion

        #region SignInPopup
        private IWebElement SignInButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement CreateAccountButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement ViewSavesButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement ManagePreferencesButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement MyLocationTextBox => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement UpdateButton => driver.FindElement(By.XPath("enter xpath here"));
        #endregion

        #region Explore Vehicles Elements
        private IWebElement ExploreSpecificCarButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement BuildSpecificCarButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement SpecificCarPriceElement => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement CarAndMinivansSectionButton => driver.FindElement(By.XPath("enter xpath here"));
        private IWebElement TruckSectionButton => driver.FindElement(By.XPath("enter xpath here"));
        #endregion
    }
}

