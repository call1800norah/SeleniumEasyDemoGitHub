using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumEasyDemo;
using SeleniumEasyDemo.InputForms;
using System;
using System.Collections.Generic;
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
                Thread.Sleep(3000);
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
            var checkboxOptionString = new List<string>() { "Option1", "Option2", "Option3", "Option4" };
            var multiCheckboxMessagesString = new List<string>() { "Click on 'Check All' to check all checkboxes at once.",
            "When you check all the checkboxes, button will change to 'Uncheck All'", "When you uncheck at least one checkbox, button will change to 'Check All'"};
            VerifyElementCollection(checkboxUnitTestPO.CheckboxOptions, checkboxOptionString);
            VerifyElementCollection(checkboxUnitTestPO.MultiCheckboxMessages, multiCheckboxMessagesString);
        }
    }
}
