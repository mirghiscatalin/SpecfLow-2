using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualSeleniumProject.tools;

namespace VisualSeleniumProject.pages
{
    class AbstractPage
    {

        public IWebDriver driver;

        public AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //the values should be represented in seconds
        public void constantWait(double delay, double interval)
        {
            // Causes the WebDriver to wait for at least a fixed delay
            var now = DateTime.Now;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(delay));
            wait.PollingInterval = TimeSpan.FromSeconds(interval);
            wait.Until((d) => (DateTime.Now - now) - TimeSpan.FromSeconds(delay) > TimeSpan.Zero);
        }

        public void waitForDocumentReadyState()
        {
            IWait<IWebDriver> wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(Constants.WAIT_TIME));
            wait.Until((d) => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public void waitForElementBy(By bySelector)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Constants.WAIT_TIME));
            wait.Until((d) => { return d.FindElement(bySelector); });
        }


        public String waitForPageTitle(String pageTitle)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Constants.WAIT_TIME));
            wait.Until((d) => { return d.Title.ToLower().StartsWith(pageTitle.ToLower()); });

            return driver.Title;
        }

        //Navigation method to URL
        public void navigateTo(string baseUrl)
        {
            driver.Navigate().GoToUrl(baseUrl);
           
            driver.Manage().Window.Maximize();

            ScreenshotHandler.captureScreenshot(driver);
        }

        //general method to click on a webelement
        public void actionClick(By bySelector)
        {
            waitForElementBy(bySelector);

            IWebElement clickableWE = driver.FindElement(bySelector);
            clickableWE.Click();

            //TODO remove repoting screenCapture if extentReports are used
            ScreenshotHandler.captureScreenshot(driver);
        }

        //general method to sendKeys to a webelement
        public void actionSendKeys(By bySelector, String text)
        {
            waitForElementBy(bySelector);
            IWebElement sendKeysWE = driver.FindElement(bySelector);
            sendKeysWE.SendKeys(text);

            //TODO remove repoting screenCapture if extentReports are used
            ScreenshotHandler.captureScreenshot(driver);
        }
    }
}
