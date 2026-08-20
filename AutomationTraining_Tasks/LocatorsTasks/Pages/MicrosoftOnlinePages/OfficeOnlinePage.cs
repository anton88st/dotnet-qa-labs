using OpenQA.Selenium;

namespace LocatorsTasks.Pages.MicrosoftOnlinePages
{
    internal class OfficeOnlinePage
    {
        private WebDriver driver;
        /*
         * Enter xpath for the following web elements. You should change the phrase 'enter css here' to correct css selector.
         * Web page Url: https://www.office.com/
         */

        #region Left application bar
        private IWebElement NineDotsButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement HomeButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement CreateContent => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement AppsButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement WordButton => driver.FindElement(By.CssSelector("enter css here"));
        #endregion

        #region Header section
        private IWebElement Microsoft365TextElement => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement SearchTextField => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement GearButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement QuestionMarkButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement AccountManagerButton => driver.FindElement(By.CssSelector("enter css here"));
        #endregion

        #region Central section
        private IWebElement InstallAppsDropDown => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement Microsoft365AppsButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement OtherInstallOptionsButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement CreateNewButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement UploadButton => driver.FindElement(By.CssSelector("enter css here"));
        #endregion
    }
}
