using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using TechTalk.SpecFlow;
using VisualSeleniumProject.tools;

namespace VisualSeleniumProject.com.steps
{
    [Binding]
    class RestSharpSteps : AbstractSteps
    {

        public RestSharpSteps(IWebDriver driver)
            : base(driver)
        {
            this.driver = driver;
            
        }


        //Home Page

        public void SearchFor(String searchTerm)
        {
            googleSearchPage.searchFor(searchTerm);
            //loggerInfo(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public void GetCategories(String expectedText)
        {

            String x = restSharpPage.restSharpTestMethod();



            //loggerInfo("This is it!!!" + x);

            //verifyTrue("The ID is not correct", x, expectedText);

        }


        public void postTest()
        {
            //loggerInfo("This is the ID: " + restSharpPage.ExecutePostWithDefaultValues());
          //  verifyTrue("The ID is: ", "201", restSharpPage.ExecutePostWithDefaultValues());
        }

        [Given(@"I want to create a new document I make a POST request")]
        public void GivenIWantToCreateANewDocumentIMakeAPOSTRequest()
        {
            //  verifyTrue("The ID is: ", "201", restSharpPage.ExecutePostWithDefaultValues());
            Assert.AreEqual(restSharpPage.ExecutePostWithDefaultValues(), "201", "The id is");
        }


        public void putTest()
        {
            //loggerInfo("This is the updated doc: " + restSharpPage.ExecutePutMethod());
           // verifyTrue("This is the response code: ", "OK", restSharpPage.ExecutePutMethod());
        }

        [Given(@"To modify the docJson name I make a PUT request")]
        public void GivenToModifyTheDocJsonNameIntoIMakeAPUTRequest()
        {
            Assert.AreEqual(restSharpPage.ExecutePutMethod(), "200", "The id is");
        }


        /*[When(@"DocJson name becomes ""(.*)""")]
        public void WhenDocJsonNameBecomes(string p0)
        {
            Assert.AreEqual(restSharpPage.ExecutePutMethod(), "200", "The id is");
        }*/


        public void putTestAfterDelete()
        {
            //loggerInfo("This is the updated doc: " + restSharpPage.ExecutePutMethod());
          //  verifyTrue("This is the response code: ", "NotFound", restSharpPage.ExecutePutMethod());
        }

      

        [Then(@"To check that the document was deleted I make a PUT request")]
        public void ThenToCheckThatTheDocumentWasDeletedIMakeAPUTRequest()
        {
            Assert.AreEqual(restSharpPage.ExecutePutMethod(), "404", "The id is");
        }


        public void getTest()
        {
            //loggerInfo("This is the status code : " + restSharpPage.ExecuteGetMethod());
           // verifyTrue("Get test failed: ", "test123", restSharpPage.ExecuteGetMethod());
        }

        [Given(@"To check that the docJson name has been modified into ""(.*)"" I make a GET request")]
        public void GivenToCheckThatTheDocJsonNameHasBeenModifiedIntoIMakeAGETRequest(string p0)
        {
            Assert.AreEqual(p0, restSharpPage.ExecuteGetMethod(), "Names doesn't match");
        }


       /* [Then(@"DocJson name should be ""(.*)""")]

        public void ThenDocJsonNameShouldBe(string p0)
        {
            Assert.AreEqual(p0, restSharpPage.ExecuteGetMethod(), "Names doesn't match");
        }*/


        public void getTestAfterPost()
        {
            //verifyTrue("This is the docJson name: ", "Test DocJson Name", restSharpPage.ExecuteGetMethodAfterPost());
        }

        [Given(@"To check that the docJson name is ""(.*)"" I make a GET request")]
        public void GivenToCheckThatTheDocJsonNameIsIMakeAGETRequest(string p0)
        {
            Assert.AreEqual(p0, restSharpPage.ExecuteGetMethodAfterPost(), "Names doesn't match");
        }


        public void deleteTest()
        {
            //loggerInfo("This is the status code: " + restSharpPage.ExecuteDeleteMethod());
           // verifyTrue("This is the response code: ", "OK", restSharpPage.ExecuteDeleteMethod());
        }

        [When(@"I want to delete the document I make a DELETE request")]
        public void WhenIWantToDeleteTheDocumentIMakeADELETERequest()
        {
            Assert.AreEqual(restSharpPage.ExecuteDeleteMethod(), "200", "The id is");
        }


        public void getTestAfterDelete()
        {
          //  verifyTrue("Delete test failed! ", "0", restSharpPage.GetContentLength().ToString());
        }

        /*        [Then(@"To check that the document was deleted I make a GET request")]
        public void ThenToCheckThatTheDocumentWasDeletedIMakeAGETRequest()
        {
            Assert.(restSharpPage.GetContentLength(), "0", "The doc was not deleted");
        }*/

    }
}
