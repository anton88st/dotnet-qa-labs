namespace TestSuiteTask
{
    public class AMDTests
    {
        /*
         * Create a test suite, included 5 tests, for the web site https://www.amd.com/. Description of each test is under the attribute 'Test'.
         * 
         * Tips and tricks:
         * - Apply OOP for creating infrastructure and test environment.
         * - Create a separate classes for each page.
         * - Apply page object model for page's depiction.
         * - Hide driver, element methods in helpers.
         * - Add logic for handling waiters and some common exceptions.
         */

        [Test]
        public void MainPageCheck() { }
        /*
         * Open the main page and verify the following:
         * 1. Header contains buttons : Products, Solutions, Resources & Support, Shop.
         * 2. Header contains icons: Sign In/Out, Language, Search, Shopping Cart.
         * 3. Tracking information contains four elements.
         * 4. Latest News contains four elements in descending order by date.
         * 5. Footer contains seven clickable social media icons.
         */

        [Test]
        public void ProductsSectionPopupCheck() { }
        /*
         * Open the main page, click on Products section and verify the following:
         * 1. Expanded Section contains 5 main elements: Procssors, Graphics, Adaptive SoCs & FPGAs, Accelerators, SOMs, & SmartNICs, Software, Tools, & Apps.
         * 2. Expanded Graphics section. The section should contain: Workstations, Desktops, Laptops, Resources.
         * 3. Verify that Graphics button change its color from black to white, if the user selects it.
         * 4. Verify that section container has white color.
         * 5. Verify if the user clicks one time on Products section, the system expands section. If the user clicks the second time on Products section, the system collapses the section.
         */

        [Test]
        public void CreateAccountPageCheck() { }
        /*
         * Open the main page, expand Sign in section, click 'Create Account' and verify:
         * 1. Verify the title is: AMD Account Creation
         * 2. Verify the following fields are existed: First Name, Last Name, E-mail, Preferred Language, Location.
         * 3. Verify the button Submit exists.
         * 4. Verify the Preferred Language dropdown contains 10 specific languages.
         * 5. Verify that First Name, Last Name, E-mail are required fields.
         */

        [Test]
        public void VerifySearchFieldAndSiteSearchPage() { }
        /*
         * Open the main page, open search field and verify:
         * 1. Search text fields is grey by color.
         * 2. Verify that under search field suggestions are displayed.
         * 3. Enter the following text: Ryzen.
         * 4. Verify suggestions contain Ryzen word.
         * 5. Click enter
         * 6. Verify that Site Search page is opened.
         * 7. Verify the page contains: search field, Results per page, and some results are existed.
         * 8. Verify the default results per page is 12 and 12 items are in the search result.
         * 9. Changes value to 24 and verify that 24 result are in the search results.
         * 10. Verify that all results contain a link to a page.
         * 11. Click the first search result and verify that the new page is opened.
         */

        [Test]
        public void AMDRadeonRXGraphicsforLaptopsPageCheck() { }
        /*
         * Open the main page, expand Graphics section and open Radion Mobile Graphics page. Verify the following:
         * 1. There is a video on the page. Verfiy that the format of video is mp4.
         * 2. Verify elements Overview, Performance, Feature, Specification are displayed.
         * 3. Click on Specification.
         * 4. Verfiy the bar with icon from the step 2 still presents.
         * 5. Verify the table AMD Radeon™ RX 7000M Series Graphics is displayed.
         * 6. Verfiy the order of Model is in descending order by model.
         * 7. Verfiy columns are displayed: Compute Units, Game frequency, infinity cache, Max memory size, Memory type.
         * 8. Verify tooltip text under Game frequency is: 'Game Frequency’ is the expected GPU clock when running typical gaming applications, 
         * set to typical TGP (Total Graphics Power). Actual individual game clock results may vary. GD-147'
         */
    }
}
