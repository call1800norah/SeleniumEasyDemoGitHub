using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyDemo
{
    public class UnitTestBase
    {
        public IWebDriver driver;
        public WebDriverWait wait;

        [TestInitialize]
        public void SetupBrowser()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
            driver.Manage().Window.Maximize();
            Assert.AreEqual("Selenium Easy Demo - Simple Form to Automate using Selenium", driver.Title);
        }
        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();
        }
        public void ElementList(List<IWebElement> element)
        {
            var isEachElementDisplayed = element.Where(e => e != null).Aggregate((first, second) => first.Displayed ? second : null);
            Assert.IsTrue(isEachElementDisplayed.Displayed, $"nameof{isEachElementDisplayed} was not displayed");


        }

    }
}