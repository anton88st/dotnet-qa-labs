using AMDTestSuiteTask.Common.Web.Extensions;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Drawing;

namespace AMDTestSuiteTask.Common.Web.BaseElements
{
    internal class CustomWebElement(By by)
    {
        private static readonly TimeSpan Timeout = TimeSpan.FromMilliseconds(TestSettingsContainer.TestSettings.Timeout);

        private static IWebDriver Driver => WebDriverFactory.Driver;
        private IWebElement WebElement => Driver.GetWebElementIfExists(by);

        public void Click()
        {
            Driver.GetWait(exceptionTypes: [typeof(StaleElementReferenceException), typeof(ElementNotInteractableException), typeof(ElementClickInterceptedException)
                ])
                .Until(drv =>
                {
                    WebElement.Click();

                    return true;
                });
        }

        public IWebElement FindElement(By by) => GetElementIfExists(by);

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            try
            {
                return WebElement.FindElements(by);
            }
            catch (StaleElementReferenceException)
            {
                return WebElement.FindElements(by);
            }
        }

        public bool IsDisplayed(int timeout = 3000)
        {
            try
            {
                WaitForElementIsDisplayed(timeout);

                return true;
            }
            catch (Exception exception) when (exception is WebDriverTimeoutException or NoSuchElementException) { return false; }
        }
        public By Selector => by;

        #region Inherit data

        public string TagName => WebElement.TagName;

        public string Text => WebElement.Text;

        public bool Enabled => WebElement.Enabled;

        public bool Selected => WebElement.Selected;

        public Point Location => WebElement.Location;

        public Size Size => WebElement.Size;

        public bool Displayed => WebElement.Displayed;

        public IWebElement WrappedElement => WebElement;

        public void Clear() => WebElement.Clear();

        public string GetAttribute(string attributeName) => WebElement.GetAttribute(attributeName);

        public string GetCssValue(string propertyName) => WebElement.GetCssValue(propertyName);

        public string GetDomAttribute(string attributeName) => WebElement.GetDomAttribute(attributeName);

        public string GetDomProperty(string propertyName) => WebElement.GetDomProperty(propertyName);

        public ISearchContext GetShadowRoot() => WebElement.GetShadowRoot();

        public void SendKeys(string text) => WebElement.SendKeys(text);

        public void Submit() => WebElement.Submit();
        #endregion

        private IWebElement GetElementIfExists(By locator)
        {
            try
            {
                Driver.GetWait().Until(_ => WebElement.FindElements(locator).Count > 0);
                Point? previousLocation = null;
                Driver.GetWait().Until(_ =>
                {
                    var currentLocation = WebElement.FindElements(locator).FirstOrDefault()?.Location;
                    var isStable = currentLocation != null && previousLocation == currentLocation;
                    previousLocation = currentLocation;

                    return isStable;
                });
            }
            catch (WebDriverTimeoutException exception)
            {
                throw new WebDriverTimeoutException($"The element with {locator} locator was not found\n{exception.InnerException?.Message}");
            }

            return WebElement.FindElement(locator);
        }
        
        private void WaitForElementIsDisplayed(int? timeout = null) => Driver
            .GetWait(timeout == null ? Timeout : TimeSpan.FromMilliseconds((int)timeout))
            .Until(drv => drv.FindElement(by).Displayed);
    }
}
