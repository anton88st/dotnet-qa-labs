using OpenQA.Selenium;
using SharePointTestSuiteTask.Common.Web.BaseElements;

namespace SharePointTestSuiteTask.Pages
{
    public class MicrosoftLoginPage
    {
        private CustomWebElement SignInText => new(By.XPath("//*[@id='loginHeader']"));
        private CustomWebElement EmailTextField => new(By.XPath("//*[@type='email']"));
        private CustomWebElement NextButton => new(By.XPath("//*[@type='submit']"));
        private CustomWebElement PasswordField => new(By.XPath("//*[@type='password']"));
        private CustomWebElement StaySignedInText => new(By.XPath("//*[text()='Stay signed in?']"));
        private CustomWebElement PickupAnAccountText => new(By.XPath("//*[text()='Pick an account']"));
        private CustomWebElement UseAnotherAccountButton => new(By.XPath("//*[@id='otherTile']"));

        public void SetEmail(string email) => EmailTextField.SendKeys(email);

        public void SetPassword(string password) => PasswordField.SendKeys(password);

        public void ClickNext() => NextButton.Click();

        public void ConfirmStaySignedIn()
        {
            if (StaySignedInText.IsDisplayed())
                NextButton.Click();
        }

        public void ClickUserAnotherAccount() => UseAnotherAccountButton.Click();

        public void LoginToMIcrosoftOnline(string email, string password)
        {
            if (PickupAnAccountText.IsDisplayed())
            {
                ClickUserAnotherAccount();
            }
            if (SignInText.IsDisplayed())
            {
                SetEmail(email);
                ClickNext();
                SetPassword(password);
                ClickNext();
                ConfirmStaySignedIn();
            }
        }
    }
}
