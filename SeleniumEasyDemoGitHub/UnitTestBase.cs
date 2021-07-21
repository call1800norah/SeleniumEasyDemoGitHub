using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumEasyDemo.InputForms;
using SeleniumEasyDemoGitHub;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumEasyDemo
{
    public class UnitTestBase
    {
        public IWebDriver driver;
        public WebDriverWait wait;
        private UnitTestBasePO unitTestBasePO;
        private SimpleFormDemoUnitTestPO simpleFormDemoUnitTestPO;

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
        /// <summary>
        /// Method for verifying webelement list displayed and text matching with string list
        /// </summary>
        /// <param name="webElement"></param>
        /// <param name="stringElement"></param>
        public void VerifyElementList(List<IWebElement> webElement, List<string> stringElement)
        {
            var isEachElementDisplayed = webElement.Where(e => e != null).Aggregate((first, second) => first.Displayed ? second : null);
            Assert.IsTrue(isEachElementDisplayed.Displayed, $"{nameof(isEachElementDisplayed)} was not displayed");
            CompareWebElementListToStringList(webElement, stringElement);
        }
        /// <summary>
        /// Method for verifying webelement collection displayed and text matching with string list
        /// </summary>
        /// <param name="webElement"></param>
        /// <param name="stringElement"></param>
        public void VerifyElementCollection(ReadOnlyCollection<IWebElement> webElement, List<string> stringElement)
        {
            var isEachElementDisplayed = webElement.Where(e => e != null).Aggregate((first, second) => first.Displayed ? second : null);
            Assert.IsTrue(isEachElementDisplayed.Displayed, $"{nameof(isEachElementDisplayed)} was not displayed.");
            CompareWebElementCollectionToStringList(webElement, stringElement);
        }
        /// <summary>
        /// Method for comparing collection of webelement from string list
        /// </summary>
        /// <param name="webElement"></param>
        /// <param name="stringElement"></param>

        public void CompareWebElementCollectionToStringList(ReadOnlyCollection<IWebElement> webElement, List<string> stringElement)
        {
            int i = 0;
            foreach (string item in stringElement)
            {
                Assert.IsTrue(item.Equals(webElement[i].Text.Trim()), $"{nameof(CompareWebElementCollectionToStringList)}failed" +
                    $"--details: \nExpected list item '{item}', but found '{webElement[i].Text.Trim()}'");
                i++;

            }
        }
        /// <summary>
        /// Method for comparing webelement list from string list
        /// </summary>
        /// <param name="webElement"></param>
        /// <param name="stringElement"></param>
        public void CompareWebElementListToStringList(List<IWebElement> webElement, List<string> stringElement)
        {
            int i = 0;
            foreach (string item in stringElement)
            {
                Assert.IsTrue(item.Equals(webElement[i].Text.Trim()), $"{nameof(CompareWebElementListToStringList)}failed" +
                    $"--details: \nExpected list item '{item}', but found '{webElement[i].Text.Trim()}'");
                i++;
            }
        }
        /// <summary>
        /// 
        /// Method for selecting menu from menu nav bar
        /// </summary>
        /// <param name="menuName"></param>
        public void MenuList(string menuName)
        {
            unitTestBasePO = new UnitTestBasePO(driver);
            var elementList = new List<IWebElement>() { unitTestBasePO.MenuListHeader,
                unitTestBasePO.AllExamplesNavBar, unitTestBasePO.InputFormsNavBar};
            var elementListString = new List<string>() { "Menu List", "All Examples", "Input Forms" };
            VerifyElementList(elementList, elementListString);

            unitTestBasePO.InputFormsNavBar.Click();
            var elementCollectionItems = new List<string>() { "Simple Form Demo", "Checkbox Demo", "Radio Buttons Demo",
            "Select Dropdown List", "Input Form Submit", "Ajax Form Submit", "JQuery Select dropdown"};
            VerifyElementCollection(unitTestBasePO.InputFormsItems, elementCollectionItems);

            foreach (IWebElement item in unitTestBasePO.InputFormsItems)
            {
                if (item.Text.Equals(menuName))
                {
                    item.Click();
                    break;
                }
            }
        }
        /// <summary>
        ///  Method for closing Image popup
        /// </summary>

        public void ImageCloseMethod(string menuName)
        {
            simpleFormDemoUnitTestPO = new SimpleFormDemoUnitTestPO(driver);
            int timeoutInSeconds = 30;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

            if ((timeoutInSeconds <= 30) && (simpleFormDemoUnitTestPO.ImageDarkener.Displayed))
            {
                simpleFormDemoUnitTestPO.ImageCloseButton.Click();
                MenuList(menuName);             
            }
            else if ((timeoutInSeconds >= 30) && (!simpleFormDemoUnitTestPO.ImageDarkener.Displayed))
            {
                Thread.Sleep(2000);
                simpleFormDemoUnitTestPO.ImageCloseButton.Click();
                MenuList(menuName);             
            }
            else
            {
                MenuList(menuName);              
            }
        }
    }
}
