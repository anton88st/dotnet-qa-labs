using OpenQA.Selenium;
using SharePointTestSuiteTask.Common.Web.BaseElements;

namespace SharePointTestSuiteTask.Pages
{
    public class MainPage
    {
        private CustomWebElement SiteContent => new(By.XPath("//*[text()='Site contents']"));

        public Grid Grid = new("//*[@data-automationid='DetailsList']");

        public void ClickSiteContent() => SiteContent.Click();
    }
}
