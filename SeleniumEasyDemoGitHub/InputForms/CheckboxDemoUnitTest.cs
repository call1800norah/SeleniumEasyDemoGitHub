using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumEasyDemo;
using System.Collections.Generic;

namespace SeleniumEasyDemoGitHub.InputForms
{
    [TestClass]
    public class CheckboxDemoUnitTest : UnitTestBase
    {
        private CheckboxUnitTestPO checkboxUnitTestPO;
        [TestMethod]
        public void SingleCheckboxDemo()
        {
            checkboxUnitTestPO = new CheckboxUnitTestPO(driver);
            var singleCheckboxHeaderAndMessageElement = new List<IWebElement>() { checkboxUnitTestPO.SingleCheckboxHeader, checkboxUnitTestPO.SingleCheckboxHeader };
            var singleCheckboxHeaderAndMessageString = new List<string>() { "Single Checkbox Demo",
                " Clicking on the checkbox will display a success message. Keep an eye on it" };
            ElementList(singleCheckboxHeaderAndMessageElement, singleCheckboxHeaderAndMessageString);

            checkboxUnitTestPO.SingleCheckboxClick.Click();
            Assert.AreEqual("Success - Check box is checked", checkboxUnitTestPO.CheckboxCheckedMessage.Text);
  
        }
        [TestMethod]
        public void MultiCheckboxDemo()
        {
            var checkboxOptionString = new List<string>() { "Option1", "Option2", "Option3", "Option4" };
            var multiCheckboxMessagesString = new List<string>() { "Click on 'Check All' to check all checkboxes at once.",
            "When you check all the checkboxes, button will change to 'Uncheck All'", "When you uncheck at least one checkbox, button will change to 'Check All'"};
            CollectionElement(checkboxUnitTestPO.CheckboxOptions, checkboxOptionString);
            CollectionElement(checkboxUnitTestPO.MultiCheckboxMessages, multiCheckboxMessagesString);
        }
    }
}
