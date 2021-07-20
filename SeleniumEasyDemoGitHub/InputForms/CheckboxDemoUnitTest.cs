using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumEasyDemo;
using SeleniumEasyDemo.InputForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SeleniumEasyDemoGitHub.InputForms
{
    [TestClass]
    public class CheckboxDemoUnitTest : UnitTestBase
    {
        private CheckboxUnitTestPO checkboxUnitTestPO;
        private SimpleFormDemoUnitTestPO simpleFormDemoUnitTestPO;
        private WebDriverWait wait;
        [TestMethod]
        public void SingleCheckboxDemo()
        {
            checkboxUnitTestPO = new CheckboxUnitTestPO(driver);
            simpleFormDemoUnitTestPO = new SimpleFormDemoUnitTestPO(driver);
            int timeoutInSeconds = 30;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));          
           
            if ((timeoutInSeconds <= 30) && (simpleFormDemoUnitTestPO.ImageDarkener.Displayed))
            {
                simpleFormDemoUnitTestPO.ImageCloseButton.Click();
                MenuList("Checkbox Demo");
                SingleCheckboxDemoMethod();
            }
            else if((timeoutInSeconds >= 30) && (!simpleFormDemoUnitTestPO.ImageDarkener.Displayed))
            {
                Thread.Sleep(2000);
                simpleFormDemoUnitTestPO.ImageCloseButton.Click();
                MenuList("Checkbox Demo");
                SingleCheckboxDemoMethod();
            }
            else
            {
                MenuList("Checkbox Demo");
                SingleCheckboxDemoMethod();
            }
            checkboxUnitTestPO.SingleCheckboxClick.Click();
            Assert.AreEqual("Success - Check box is checked", checkboxUnitTestPO.CheckboxCheckedMessage.Text);
  
        }
        public void SingleCheckboxDemoMethod()
        {          
            var singleCheckboxHeaderAndMessageElement = new List<IWebElement>() { checkboxUnitTestPO.SingleCheckboxHeader, checkboxUnitTestPO.SingleCheckboxMessage };
            var singleCheckboxHeaderAndMessageString = new List<string>() { "Single Checkbox Demo",
            "Clicking on the checkbox will display a success message. Keep an eye on it" };
            VerifyElementList(singleCheckboxHeaderAndMessageElement, singleCheckboxHeaderAndMessageString);          
        }
        [TestMethod]
        public void MultiCheckboxDemo()
        {
            checkboxUnitTestPO = new CheckboxUnitTestPO(driver);
            simpleFormDemoUnitTestPO = new SimpleFormDemoUnitTestPO(driver);
            int timeoutInSeconds = 30;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            if ((timeoutInSeconds <= 30) && (simpleFormDemoUnitTestPO.ImageDarkener.Displayed))
            {
                simpleFormDemoUnitTestPO.ImageCloseButton.Click();
                MenuList("Checkbox Demo");
                MultipleCheckboxDemoMethod();

            }
            else if((timeoutInSeconds >= 30) && (!simpleFormDemoUnitTestPO.ImageDarkener.Displayed))
            {
                Thread.Sleep(2000);
                simpleFormDemoUnitTestPO.ImageCloseButton.Click();
                MenuList("Checkbox Demo");
                MultipleCheckboxDemoMethod();
            }
            else
            {
                MenuList("Checkbox Demo");
                MultipleCheckboxDemoMethod();
            }         
            checkboxUnitTestPO.CheckAllButton.Click();
            checkboxUnitTestPO.UnCheckAllButton.Click();            
        }
        public void MultipleCheckboxDemoMethod()
        {
            Assert.IsTrue(checkboxUnitTestPO.MultiCheckboxHeader.Displayed, $"{nameof(checkboxUnitTestPO.MultiCheckboxHeader)} returned as null!");
            Assert.IsTrue(checkboxUnitTestPO.MultiCheckboxMessage.Displayed, $"{nameof(checkboxUnitTestPO.MultiCheckboxMessage)} returned as null!");
            var checkboxOptionString = new List<string>() { "Option 1", "Option 2", "Option 3", "Option 4" };
            var multiCheckboxMessagesString = new List<string>() { "Click on 'Check All' to check all checkboxes at once.",
            "When you check all the checkboxes, button will change to 'Uncheck All'", "When you uncheck at least one checkbox, button will change to 'Check All'"};
            VerifyElementCollection(checkboxUnitTestPO.CheckboxOptions, checkboxOptionString);
            VerifyElementCollection(checkboxUnitTestPO.MultiCheckboxMessages, multiCheckboxMessagesString);
        }
    }
}
