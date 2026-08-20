using OpenQA.Selenium;

namespace LocatorsTasks.Pages.ToyotaPages
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
         * Web page Url: https://www.toyota.com/
         */

        #region Header's buttons
        private const string NavigationBarLocator = "//*[@class='main-navigation-bar']";
        private IWebElement VehiclesDropDown => driver.FindElement(By.XPath($"{NavigationBarLocator}//*[contains(text(),'Vehicles')]"));
        private IWebElement ShoppingToolsDropDown => driver.FindElement(By.XPath($"{NavigationBarLocator}//*[contains(text(),'Shopping Tools')]"));
        private IWebElement SignInDropDown => driver.FindElement(By.XPath($"{NavigationBarLocator}//*[@class='hamburger']"));
        private IWebElement OwnersDropDown => driver.FindElement(By.XPath($"{NavigationBarLocator}//*[contains(text(),'Owners')]"));
        #endregion

        #region SignInPopup
        private const string ToyotaViewLocator = "//*[@class='desktop-dropdown']//*[contains(@class,'dropdown-view expanded') and ./*[contains(@class,'my-toyota-view')]]";
        private IWebElement SignInButton => driver.FindElement(By.XPath($"{ToyotaViewLocator}//*[@class='sign-in-block']//*[text()='Sign In']"));
        private IWebElement CreateAccountButton => driver.FindElement(By.XPath($"{ToyotaViewLocator}//*[@class='sign-in-block']//*[contains(text(),'Create Account')]"));
        private IWebElement ViewSavesButton => driver.FindElement(By.XPath($"{ToyotaViewLocator}//*[@class='saves']"));
        private IWebElement ManagePreferencesButton => driver.FindElement(By.XPath($"{ToyotaViewLocator}//*[@class='primary-cta ']"));
        private IWebElement MyLocationTextBox => driver.FindElement(By.XPath($"{ToyotaViewLocator}//form[@class='zipcode-form']//input"));
        private IWebElement UpdateButton => driver.FindElement(By.XPath($"{ToyotaViewLocator}//form[@class='zipcode-form']//button"));
        #endregion

        #region Explore Vehicles Elements
        private const string SubSectionButtonLocator = 
            "//section[@data-aa-content-subsection='{0}']//div[contains(@class,'active') and ./*[@class='vehicle-selector']]//*[@role='listitem' and .//*[contains(@class,'title')" +
            " and contains(text(),'{1}')]]//a[.//*[contains(text(),'{2}')]]";
        private IWebElement ExploreSpecificCarButton => driver.FindElement(By.XPath(string.Format(SubSectionButtonLocator, "Cars & Minivan", "Toyota Crown", "Explore")));
        private IWebElement BuildSpecificCarButton => driver.FindElement(By.XPath(string.Format(SubSectionButtonLocator, "Cars & Minivan", "Toyota Crown", "Build")));
        private IWebElement SpecificCarPriceElement => driver.FindElement(By.XPath(string.Format(SubSectionButtonLocator, "Cars & Minivan", "Toyota Crown", "Price")));
        private IWebElement CarAndMinivansSectionButton => driver.FindElement(By.XPath("//li[@data-aa-content-item='Cars & Minivan']"));
        private IWebElement TruckSectionButton => driver.FindElement(By.XPath("//li[@data-aa-content-item='Trucks']"));
        #endregion
    }
}

