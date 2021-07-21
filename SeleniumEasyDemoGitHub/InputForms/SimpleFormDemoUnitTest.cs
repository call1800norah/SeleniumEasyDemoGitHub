using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace SeleniumEasyDemo.InputForms
{
    [TestClass]
    public class SimpleFormDemoUnitTest : UnitTestBase
    {
        /// <summary>
        /// Test for single input field
        /// </summary>
        [TestMethod]
        public void SingleInputFieldUnitTest()
        {
            var simpleForm = new SimpleFormDemoUnitTestPO(driver);
            var labelsElementList = new List<IWebElement> { simpleForm.EnterMessageLabel, simpleForm.YourMessageLabel };
            var labelListString = new List<string>() { "Enter message", "Your Message:" };

            //Verify message headers and texts displayed
            VerifyElementList(labelsElementList, labelListString);

            //Method for closing Image popup
            ImageCloseMethod("Input Forms");

            InputMesssage("Hello Selenium");
        }
        /// <summary>
        /// Method for inputting message and see the output displayed
        /// </summary>
        /// <param name="message"></param>
        private void InputMesssage(string message)
        {
            var simpleForm = new SimpleFormDemoUnitTestPO(driver);
            simpleForm.InputMessageBox.SendKeys(message);
            simpleForm.ShowMessageButton.Click();
            Assert.AreEqual(message, simpleForm.MessageDisplay.Text, $"nameof{message} was not displayed.");
        }
        /// <summary>
        /// Test for the result of two input numbers and output of the sum
        /// </summary>
        [TestMethod]
        public void TwoInputFieldUnitTest()
        {
            var simpleForm = new SimpleFormDemoUnitTestPO(driver);
            List<IWebElement> twoInputLabelsElement = new List<IWebElement> { simpleForm.EnteraLabel,
                simpleForm.EnterbLabel, simpleForm.TotalLabel};
            var twoInputLabelsString = new List<string>() { "Enter a", "Enter b", "Total a + b =" };
            VerifyElementList(twoInputLabelsElement, twoInputLabelsString);
            ImageCloseMethod("Input Forms");
            SumOfTwoNumbers(5, 6);           
        }
        /// <summary>
        /// Method for inputting two numbers in each field and see the output of the sum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
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