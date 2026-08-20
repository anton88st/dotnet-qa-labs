using OpenQA.Selenium;

namespace LocatorsTasks.Pages.MicrosoftOnlinePages
{
    internal class MicrosoftLoginPage
    {
        private WebDriver driver;
        /*
         * Enter xpath for the following web elements. You should change the phrase 'enter css here' to correct css selector.
         * Web page Url: https://login.microsoftonline.com/
         */

        #region Sign in section
        private IWebElement EmailTextField => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement CreateOneLink => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement CantAccessYouAccountLink => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement BackButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement NextButton => driver.FindElement(By.CssSelector("enter css here"));
        #endregion

        #region Password section
        private IWebElement PasswordTextField => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement ForgotMyPasswordLink => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement SignInButton => driver.FindElement(By.CssSelector("enter css here"));
        #endregion
    }
}
