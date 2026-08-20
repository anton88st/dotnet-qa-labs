namespace SharePointTestSuiteTask
{
    public class SharePointTests
    {
        /*
         * Create a test suite, included UI and API tests, for the web site <SharePoint site URL>.
         * Sign in credentials: email - <email>, password - <password>.
         * For API request should use Graph API. All permissions have already configured on Application side for working with Graph API. 
         * Read documentation before the task development:
         * - https://learn.microsoft.com/en-us/graph/overview (Graph overview)
         * - https://learn.microsoft.com/en-us/graph/sdks/choose-authentication-providers?tabs=csharp#client-credentials-provider (Apply ClientSecret as authentication provider for accessing graph instances)
         * - https://learn.microsoft.com/en-us/graph/api/overview?view=graph-rest-1.0 (Graph API endpoints)
         * - https://learn.microsoft.com/en-us/graph/query-parameters?context=graph%2Fapi%2F1.0&view=graph-rest-1.0&tabs=http (Filtering/searching through graph instances)
         * 
         * Description of each test is under the attribute 'Test'. Client secret credentials: 
         * - ClientId = "<ClientId>";
         * - TenantId = "<TenantId>";
         * - AppSecret = "<AppSecret>";
         * 
         * Tips and tricks:
         * - Apply OOP for creating infrastructure and test environment.
         * - Create a separate classes for each page.
         * - Apply page object model for page's depiction.
         * - Hide driver, element methods in helpers.
         * - Add logic for handling waiters and some common exceptions.
         * - Add separate classes for handling API.
         */

        [Test]
        public void CreateLibraryViaApiAndCheckOnUI()
        {
            /*
             * 1. Create a document library on site via Graph API call. 
             * 2. In browser, open a sharepoint site page -> click on Site Contents.
             * 3. Verify that new library is present.
             * 4. Remove the document library from the site via Graph API call.
             * 5. Refresh the page and verify that the library is no longer existed.
             */
        }

        [Test]
        public void CreateLibraryAndFolderThenCheckOnUI()
        {
            /*
             * 1. Create a document library on site via Graph API call.
             * 2. Create a folder in the library from the step 1 via Graph API call.
             * 3. In browser, open a sharepoint site page -> click on Site Contents.
             * 4. Verify that new library is present.
             * 5. Open library and check that the folder is present.
             * 6. Create a new folder in the library via UI.
             * 7. Verify that the folder is present in the Graph API instance.
             * 8. Remove the document library from the site via Graph API call.
             * 9. Refresh the page and verify that the library is no longer existed.
             */
        }

        [Test]
        public void CreateFolderWithTxtFileInLibraryAndCheckOnUI()
        {
            /*
             * 1. Create a document library on site via Graph API call.
             * 2. Create a folder in the library from the step 1 via Graph API call.
             * 3. Add txt file to the folder via Graph API call.
             * 4. In browser, open a sharepoint site page -> click on Site Contents.
             * 5. Verify that new library is present.
             * 6. Open library and check that the folder is present.
             * 7. Open folder and check that the file is present.
             * 8. Add new txt file to the folder via UI.
             * 7. Verify that the file is present in the Graph API instance.
             * 8. Remove the both files from the folder via Graph API call.
             * 9. Refresh the page and verify that files are no longer existed.
             * 10. Remove the document library from the site via Graph API call.
             * 11. Refresh the page and verify that the library is no longer existed.
             */
        }

        [Test]
        public void CreateNewUserAndViewPermissionForFolderAndCheckUI()
        {
            /*
             * 1. Create a document library on site via Graph API call.
             * 2. Create a folder in the library from the step 1 via Graph API call.
             * 3. Add txt file to the library via Graph API call.
             * 4. Create a new user via Graph API call.
             * 5. Give a View permissions to the user from the step 4 to the folder from the step 2.
             * 4. In browser, sign in by the user from step 4 and open a folder from the step 2.
             * 5. Verify that the folder is displayed.
             * 6. Verify that the user can't delete the folder.
             * 7. Open the folder and check that buttons Upload and New are not present.
             * 8. Remove the document library from the site via Graph API call.
             * 9. Verify that the library is no longer existed via Graph API call.
             */
        }

        [Test]
        public void CreateNewUserAndEditPermissionForFolderAndCheckUI()
        {
            /*
             * 1. Create a document library on site via Graph API call.
             * 2. Create a folder in the library from the step 1 via Graph API call.
             * 3. Add txt file to the library via Graph API call.
             * 4. Create a new user via Graph API call.
             * 5. Give a Edit permissions to the user from the step 4 to the folder from the step 2.
             * 4. In browser, sign in by the user from step 4 and open a folder from the step 2.
             * 5. Verify that the folder is displayed.
             * 6. Verify that that buttons Upload and New are present.
             * 7. Create a new folder via UI.
             * 8. Open the folder and check that button Upload is present.
             * 9. Upload a new jpg file to the folder.
             * 10. Verify that new folder and file are present in Graph API instances.
             * 11. Remove the document library from the site via Graph API call.
             * 12. Verify that the library is no longer existed via Graph API call.
             */
        }
    }
}