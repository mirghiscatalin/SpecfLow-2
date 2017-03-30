using OpenQA.Selenium;
using System;
using VisualSeleniumProject.tools;

namespace VisualSeleniumProject.pages
{
    class GoogleHomePage : AbstractPage
    {
        //Selectors used to the page
        private By inputFieldSelector = By.Name("q");

        //page constructor - extended with AbstractPage constructor
        public GoogleHomePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void searchFor(String searchTerm)
        {
            waitForElementBy(inputFieldSelector);

            IWebElement query = driver.FindElement(inputFieldSelector);
            query.SendKeys(searchTerm);
            query.Submit();

            ScreenshotHandler.captureScreenshot(driver);
        }
        
    }
}
