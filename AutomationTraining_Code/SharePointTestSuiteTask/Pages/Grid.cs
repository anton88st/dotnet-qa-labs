using OpenQA.Selenium;
using SharePointTestSuiteTask.Common.Web.BaseElements;

namespace SharePointTestSuiteTask.Pages
{
    public class Grid
    {
        private readonly string _GridXpath;

        public Grid(string xpath)
        {
            _GridXpath = xpath;
        }

        public bool IsLibraryExists(string libraryName) => GetLibraryFolderRow(libraryName).IsDisplayed();

        private CustomWebElement GetLibraryFolderRow(string libraryName) => new(By.XPath($"{_GridXpath}//*[@data-automationid='ListCell'][.//*[text()='{libraryName}']]"));
    }
}
