using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace SeleniumEasyDemo.InputForms
{
    [TestClass]
    public class SimpleFormDemoUnitTest : UnitTestBase
    {
        [TestMethod]
        public void SingleInputFieldUnitTest()
        {
            var simpleForm = new SimpleFormDemoUnitTestPO(driver);
            var labelsElementList = new List<IWebElement> { simpleForm.EnterMessageLabel, simpleForm.YourMessageLabel };
            var labelListString = new List<string>() { "Enter message", "Your Message:" };
            ElementList(labelsElementList, labelListString);
            if (simpleForm.ImageDarkener.Displayed)
            {
                simpleForm.ImageCloseButton.Click();
                InputMesssage("Hello Selenium");
            }
            else
            {
                InputMesssage("Hello Selenium");
            }
        }

        private void InputMesssage(string message)
        {
            var simpleForm = new SimpleFormDemoUnitTestPO(driver);
            simpleForm.InputMessageBox.SendKeys(message);
            simpleForm.ShowMessageButton.Click();
            Assert.AreEqual(message, simpleForm.MessageDisplay.Text, $"nameof{message} was not displayed.");
        }
        [TestMethod]
        public void TwoInputFieldUnitTest()
        {
            var simpleForm = new SimpleFormDemoUnitTestPO(driver);
            List<IWebElement> twoInputLabelsElement = new List<IWebElement> { simpleForm.EnteraLabel,
                simpleForm.EnterbLabel, simpleForm.TotalLabel};
            var twoInputLabelsString = new List<string>() { "Enter a", "Enter b", "Total a + b =" };
            ElementList(twoInputLabelsElement, twoInputLabelsString);
            if (simpleForm.ImageDarkener.Displayed)
            {
                simpleForm.ImageCloseButton.Click();
                SumOfTwoNumbers(5, 6);
            }

        }
        private void SumOfTwoNumbers(int a, int b)
        {
            var simpleForm = new SimpleFormDemoUnitTestPO(driver);
            simpleForm.InputA.SendKeys(a.ToString());
            simpleForm.InputB.SendKeys(b.ToString());
            var sum = a + b;
            simpleForm.GetTotalButton.Click();
            Assert.AreEqual(sum.ToString(), simpleForm.DisplayValue.Text, $"{nameof(simpleForm.DisplayValue)} was not displayed.");
        }
    }
}