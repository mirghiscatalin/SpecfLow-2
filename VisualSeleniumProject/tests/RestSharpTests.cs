using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisualSeleniumProject.tools;
using VisualSeleniumProject.pages;
using VisualSeleniumProject.com.steps;
using System.Diagnostics;
using VisualSeleniumProject.tests;

namespace VisualSeleniumProject
{
    /*[TestClass]
    public class PocGoogleTest : BaseTest
    {
        //test data
        private String baseUrl;
        private String searchTerm;

        //pages used
        private RestSharpSteps restSharpSteps;
        private AbstractPage abstractPage;



        [TestInitialize]
        public void before()
        {
            //init test data
            //baseUrl = Constants.BASE_URL;
            baseUrl = "http://www.google.com/";
            searchTerm = "Hamster";

            //printscreen names
            Constants.PICTURE_NAME = this.GetType().Name;

            //init webdriver
            InitializeDriver();

        }


        [TestMethod]
        public void restSharpTest()
        {
            //init used pages
            extentTestReport = extentReports
             .StartTest("BCM Service tests");
            restSharpSteps = new RestSharpSteps(driver, extentTestReport);
            abstractPage = new AbstractPage(driver);
            //abstractPage.navigateTo(baseUrl);
            //googleHomeSteps.SearchFor(searchTerm);
            //  googleHomeSteps.GetCategories("4.5384");
            restSharpSteps.postTest();
            restSharpSteps.getTestAfterPost();
            restSharpSteps.putTest();
            restSharpSteps.getTest();
            restSharpSteps.deleteTest();
            restSharpSteps.getTestAfterDelete();
            restSharpSteps.putTestAfterDelete();

            // String extractedTitle = abstractPage.waitForPageTitle(searchTerm);

            //SoftAssert.verifyTrue("Title is not as expected", "Hamster", extractedTitle );
        }

        [TestCleanup]
        public void after()
        {
            //Debug.Assert(SoftAssert.getErrorCount().CompareTo(0) == 0, "Error: Errors were found in test. Count: " + SoftAssert.getErrorCount());


            Debug.WriteLineIf(!(SoftAssert.getErrorCount().CompareTo(0) == 0), "Error: Errors were found in test. Count: " + SoftAssert.getErrorCount());

            driver.Close();
            driver.Quit();

            extentReports.EndTest(extentTestReport);
            extentReports.Flush();
            if (SoftAssert.getErrorCount() > (0))
            {
                Assert.Fail("Test failed!");
            }

        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            System.Diagnostics.Process.Start(Constants.EXTENT_REPORT_FILE);
        }
    }
    */
}
