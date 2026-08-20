using OpenQA.Selenium;

namespace LocatorsTasks.Pages.ToyotaPages
{
    internal class ToyotaMiraiBuildPage
    {
        private readonly IWebDriver driver;

        public ToyotaMiraiBuildPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /*
         * Enter xpath for the following web elements. You should change the word 'xpath' to correct xpath.
         * Web page Url: https://www.toyota.com/mirai/ -> click 'Build' button -> enter 93023 zip code and set location. 
         * You webPage Url: https://www.toyota.com/configurator/build/step/model/year/2023/series/mirai/?bap_guid=d28a86c4-33c8-47b4-97a1-0228bd3065f1
         */

        #region Your build section elements
        private const string YourBuildSectionLocator = "//*[@id='build']//*[@id='hero']";
        private IWebElement CarTitleTextElement => driver.FindElement(By.XPath($"{YourBuildSectionLocator}//*[@class='series-title']/h2"));
        private IWebElement VehicleOverviewButton => driver.FindElement(By.XPath($"{YourBuildSectionLocator}//*[@class='series-title']/a"));
        private IWebElement PriceTextElement => driver.FindElement(By.XPath($"{YourBuildSectionLocator}//*[contains(@class,'model-only price')]"));
        private IWebElement GetQuoteButton => driver.FindElement(By.XPath($"{YourBuildSectionLocator}//*[contains(@class,'hero-raq')]/button"));
        private IWebElement ExteriorRadioButton => driver.FindElement(By.XPath($"{YourBuildSectionLocator}//*[@id='angles-section']//span[text()='Exterior']"));
        private IWebElement NextExteriorRadioButton => driver.FindElement(By.XPath($"{YourBuildSectionLocator}//*[@id='angles-section']//*[@data-view='exterior' and @data-angle='2']"));
        private IWebElement InteriorRadioButton => driver.FindElement(By.XPath($"{YourBuildSectionLocator}//*[@id='angles-section']//span[text()='Interior']"));
        private IWebElement NextInteriorRadioButton => driver.FindElement(By.XPath($"{YourBuildSectionLocator}//*[@id='angles-section']//*[@data-view='interior' and @data-angle='2']"));
        private IWebElement ViewLargerImagesButton => driver.FindElement(By.XPath($"{YourBuildSectionLocator}//*[@id='angles-section']//button[.//*[contains(text(),'View Larger Images')]]"));
        #endregion

        #region Navigation buttons
        private const string NavigationButtonLocator = "//*[@id='build']//*[@id='steps-nav']//button[.//*[contains(text(),'{0}')]]";
        private IWebElement ModelsButton => driver.FindElement(By.XPath(string.Format(NavigationButtonLocator, "Models")));
        private IWebElement EnginesButton => driver.FindElement(By.XPath(string.Format(NavigationButtonLocator, "Engines")));
        private IWebElement ColorsButton => driver.FindElement(By.XPath(string.Format(NavigationButtonLocator, "Colors")));
        private IWebElement PackagesButton => driver.FindElement(By.XPath(string.Format(NavigationButtonLocator, "Packages")));
        #endregion

        #region Accessories tab elements
        private const string AccessoriesTabLocator = "//*[@id='build']//*[@id='steps']//*[@id='accessory-tab']";
        private IWebElement AllButton => driver.FindElement(By.XPath($"{AccessoriesTabLocator}//*[@class='tcom-accessory-groups tabs']//button[@data-code='all']"));
        private IWebElement InteriorButton => driver.FindElement(By.XPath($"{AccessoriesTabLocator}//*[@class='tcom-accessory-groups tabs']//button[@data-code='interior']"));
        private IWebElement ExteriorButton => driver.FindElement(By.XPath($"{AccessoriesTabLocator}//*[@class='tcom-accessory-groups tabs']//button[@data-code='exterior']"));
        private IWebElement AddSpecificAccessoryButton => driver.FindElement(By.XPath($"{AccessoriesTabLocator}//*[@class='tcom-accessory-card-group']//*[contains(@class,'tcom-accessory-card tcom-card')][.//*[contains(text(),'All-Weather Floor Liner Package')]]//button[.//*[text()='Add']]"));
        private IWebElement ViewDetailsAccessoryButton => driver.FindElement(By.XPath($"{AccessoriesTabLocator}//*[@class='tcom-accessory-card-group']//*[contains(@class,'tcom-accessory-card tcom-card')][.//*[contains(text(),'All-Weather Floor Liner Package')]]//button[text()='View Details']"));
        private IWebElement PriceAccessoryTextElement => driver.FindElement(By.XPath($"{AccessoriesTabLocator}//*[@class='tcom-accessory-card-group']//*[contains(@class,'tcom-accessory-card tcom-card')][.//*[contains(text(),'All-Weather Floor Liner Package')]]//div[contains(@class,'amount')]"));
        private IWebElement NameAccessoryTextElement => driver.FindElement(By.XPath($"{AccessoriesTabLocator}//*[@class='tcom-accessory-card-group']//*[contains(@class,'tcom-accessory-card tcom-card')][.//*[contains(text(),'All-Weather Floor Liner Package')]]//h2"));
        #endregion
    }
}
