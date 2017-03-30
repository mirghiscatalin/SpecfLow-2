using BoDi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using VisualSeleniumProject.com.tools.reports;
using VisualSeleniumProject.tools;

namespace VisualSeleniumProject.tests
{
    [Binding]
    public class BaseTest
    {
        //driver
        /* public IWebDriver driver;

         //reporting framework
         public ExtentReports extentReports;
         public ExtentTest extentTestReport;


         public void InitializeDriver()
         {

             if (Constants.BROWSER.Contains("firefox"))
             {
                 //ignore https error
                 var profile = new FirefoxProfile();
                 profile.SetPreference("webdriver_assume_untrusted_issuer", true);
                 driver = new FirefoxDriver(profile);

             }
             if (Constants.BROWSER.Contains("iexplorer"))
             {
                 driver = new InternetExplorerDriver();
             }
             if (Constants.BROWSER.Contains("chrome"))
             {
                 ChromeOptions options = new ChromeOptions();
                 options.AddArgument("--start-maximized");
                 options.AddArgument("--ignore-certificate-errors");
                 driver = new ChromeDriver(options);        
             }


             //configure driver properties
             driver.Manage().Window.Maximize();
             driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(Constants.WAIT_TIME));


             //extentReports = ExtentManager.Instance;
         }
         */

        private readonly IObjectContainer objectContainer;
        private IWebDriver webDriver;

        public BaseTest(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            webDriver = new ChromeDriver();
            objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
        }
        [AfterScenario]
        public void ScenarioTearDown()
        {
            webDriver.Quit();
        }

        [TestCleanup]
        public void CleanUp()
        {
            webDriver.Quit();

        }


    }
}

