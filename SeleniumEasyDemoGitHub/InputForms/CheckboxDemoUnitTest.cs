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
        private CheckboxDemoUnitTestPO checkboxUnitTestPO;
        
        /// <summary>
        /// Test for single checkbox
        /// </summary>
        [TestMethod]
        public void SingleCheckboxDemo()
        {
            checkboxUnitTestPO = new CheckboxDemoUnitTestPO(driver);

            //Method for closing Image popup
            ImageCloseMethod("Checkbox Demo");

            SingleCheckboxDemoMethod();
          
            checkboxUnitTestPO.SingleCheckboxClick.Click();
            Assert.AreEqual("Success - Check box is checked", checkboxUnitTestPO.CheckboxCheckedMessage.Text);
  
        }
        /// <summary>
        /// Method for verifying if the list of webelement text and the list of string displayed and texts are matching
        /// </summary>
        public void SingleCheckboxDemoMethod()
        {          
            var singleCheckboxHeaderAndMessageElement = new List<IWebElement>() { checkboxUnitTestPO.SingleCheckboxHeader, checkboxUnitTestPO.SingleCheckboxMessage };
            var singleCheckboxHeaderAndMessageString = new List<string>() { "Single Checkbox Demo",
            "Clicking on the checkbox will display a success message. Keep an eye on it" };
            VerifyElementList(singleCheckboxHeaderAndMessageElement, singleCheckboxHeaderAndMessageString);          
        }
        /// <summary>
        /// Test for multiple checkbox
        /// </summary>
        [TestMethod]
        public void MultiCheckboxDemo()
        {
            checkboxUnitTestPO = new CheckboxDemoUnitTestPO(driver);

            //Method for closing Image popup
            ImageCloseMethod("Checkbox Demo");
            MultipleCheckboxDemoMethod();
           
            //Click Check All button to check all Options
            checkboxUnitTestPO.CheckAllButton.Click();
            Assert.IsTrue(checkboxUnitTestPO.UnCheckAllButton.GetAttribute("value").Equals("Uncheck All"));
            //Click UnCheck All button to uncheck all Options
            checkboxUnitTestPO.UnCheckAllButton.Click();
            Assert.IsTrue(checkboxUnitTestPO.CheckAllButton.GetAttribute("value").Equals("Check All"));
           
        }
        /// <summary>
        ///   Method for verifying if the collection of webelement text and the list of string displayed and texts are matching
        /// </summary>
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
