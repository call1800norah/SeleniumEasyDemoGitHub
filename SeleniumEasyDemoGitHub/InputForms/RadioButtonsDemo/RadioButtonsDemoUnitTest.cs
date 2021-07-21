using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumEasyDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyDemoGitHub.InputForms
{
    [TestClass]
    public class RadioButtonsDemoUnitTest : UnitTestBase
    {
        private RadioButtonsDemoUnitTestPO radioButtonsDemoUnitTestPO;

        /// <summary>
        /// Test for radio button 
        /// </summary>
        [TestMethod]
        public void RadioButtonDemoUnitTest()
        {
            radioButtonsDemoUnitTestPO = new RadioButtonsDemoUnitTestPO(driver);

            //Method for closing Image popup
            ImageCloseMethod("Radio Buttons Demo");

            var verifyElementList = new List<IWebElement>() { radioButtonsDemoUnitTestPO.RadioButtonDemoHeader, radioButtonsDemoUnitTestPO.RadioButtonDemoMessage };
            var verifyStringList = new List<string>() { "Radio Button Demo", "Click on button to get the selected value" };
            VerifyElementList(verifyElementList, verifyStringList);

            var optionChosen = radioButtonsDemoUnitTestPO.RadioButtonOptions.FirstOrDefault();
            optionChosen.Click();
            radioButtonsDemoUnitTestPO.GetCheckedValueButton.Click();
            Assert.IsTrue(radioButtonsDemoUnitTestPO.ButtonCheckedIndicator.Text.Trim().Contains(optionChosen.GetAttribute("value")));
        }
        /// <summary>
        /// Test for group radio buttons
        /// </summary>
        [TestMethod]
        public void GroupRadioButtonsDemoUnitTest()
        {
            radioButtonsDemoUnitTestPO = new RadioButtonsDemoUnitTestPO(driver);

            //Method for closing Image popup
            ImageCloseMethod("Radio Buttons Demo");

            var verifyElementList = new List<IWebElement>() { radioButtonsDemoUnitTestPO.GroupRadioButtonsDemoHeader,
                radioButtonsDemoUnitTestPO.GroupRadioButtonsDemoMessage, radioButtonsDemoUnitTestPO.GenderLabel, radioButtonsDemoUnitTestPO.AgeGroupLabel };
            var verifyStringList = new List<string>(){"Group Radio Buttons Demo", "Click on button to get the selected values from Group Sex and Age group",
                    "Sex :", "Age Group :"};
            VerifyElementList(verifyElementList, verifyStringList);
            var genderOption = radioButtonsDemoUnitTestPO.GenderOptions.LastOrDefault();
            genderOption.Click();

            var ageOption = radioButtonsDemoUnitTestPO.AgeOptions[1];
            ageOption.Click();

            radioButtonsDemoUnitTestPO.GetValuesButton.Click();
            Assert.IsTrue(radioButtonsDemoUnitTestPO.ValueOutput.Text.Trim().Contains(genderOption.GetAttribute("value")));
            Assert.IsTrue(radioButtonsDemoUnitTestPO.ValueOutput.Text.Trim().Contains(ageOption.GetAttribute("value")));         
        }
    }
}
