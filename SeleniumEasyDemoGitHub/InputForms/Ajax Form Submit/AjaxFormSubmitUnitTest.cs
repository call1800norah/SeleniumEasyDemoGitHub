using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumEasyDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumEasyDemoGitHub.InputForms.Ajax_Form_Submit
{
    [TestClass]
    public class AjaxFormSubmitUnitTest : UnitTestBase
    {
        private AjaxFormSubmitUnitTestPO ajaxForm;
        
        [TestMethod]
        public void AjaxFormUnitTest()
        {
            ajaxForm = new AjaxFormSubmitUnitTestPO(driver);

            //Method for closing Image popup
            ImageCloseMethod("Ajax Form Submit");

            var ajaxHeaderAndLabelWebElementList = new List<IWebElement>() { ajaxForm.AjaxFormHeader, ajaxForm.NameLabel, ajaxForm.CommentLabel };
            var ajaxHeaderAndLabelStringList = new List<string>() { "Ajax Form", "Name:", "Comment:" };
            VerifyElementList(ajaxHeaderAndLabelWebElementList, ajaxHeaderAndLabelStringList);

            ajaxForm.InputName.SendKeys("Norah");
            ajaxForm.InputComment.SendKeys("Hello Selenium");
            ajaxForm.SubmitButton.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(e => ajaxForm.SubmitSuccessMessage.Displayed);
            Assert.AreEqual(ajaxForm.SubmitSuccessMessage.Text.Trim(), "Ajax Request is Processing!");
            Thread.Sleep(3000);
            Assert.AreEqual(ajaxForm.SubmitSuccessMessage.Text.Trim(), "Form submited Successfully!");

        }
    }
}
