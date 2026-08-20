using OpenQA.Selenium;

namespace LocatorsTasks.Pages.MicrosoftOnlinePages
{
    internal class OutlookOnlinePage
    {
        private WebDriver driver;
        /*
         * Enter xpath for the following web elements. You should change the phrase 'enter css here' to correct css selector.
         * Web page Url: https://outlook.office.com/
         */

        #region Outlook menu in the header
        private IWebElement ThreeLinesButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement HomeButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement ViewButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement HelpButton => driver.FindElement(By.CssSelector("enter css here"));
        #endregion

        #region View menu bar
        private IWebElement ViewSettingsButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement MessagesButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement LayoutDropDown => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement DensityDropDown => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement ThreeDotsButton => driver.FindElement(By.CssSelector("enter css here"));
        #endregion

        #region Layout section
        private IWebElement RibbonElement => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement FolderPaneElement => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement ReadingPaneElement => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement FolderPaneShowCheckbox => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement FolderPaneHideCheckbox => driver.FindElement(By.CssSelector("enter css here"));
        #endregion

        #region Folders section
        private IWebElement InboxButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement DraftButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement JunkEmailsButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement DeletedItemsButton => driver.FindElement(By.CssSelector("enter css here"));
        #endregion

        #region Favorites section
        private IWebElement InboxFavoritesButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement DraftFavoritesButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement SentItemsFavoritesButton => driver.FindElement(By.CssSelector("enter css here"));
        #endregion

        #region Openmed Email section
        private IWebElement SenderTextElement => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement ReceiverTextElement => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement DateTimeElement => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement SmilesIcon => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement ReplyIcon => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement BodyTextElement => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement ThreeDotsDropDown => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement ReplyButton => driver.FindElement(By.CssSelector("enter css here"));
        private IWebElement ForwardButton => driver.FindElement(By.CssSelector("enter css here"));
        #endregion
    }
}
