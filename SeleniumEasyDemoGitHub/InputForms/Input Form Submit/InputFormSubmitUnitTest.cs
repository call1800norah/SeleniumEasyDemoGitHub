using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumEasyDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyDemoGitHub.InputForms.Input_Form_Submit
{
    [TestClass]
    public class InputFormSubmitUnitTest : UnitTestBase
    {
        private InputFormSubmitUnitTestPO inputForm;
        private Random random;

        [TestMethod]
        public void InputFormUnitTest()
        {
            inputForm = new InputFormSubmitUnitTestPO(driver);

            //Method for closing Image popup
            ImageCloseMethod("Input Form Submit");

            var inputFormHeadersAndLabelsWebElementList = new List<IWebElement>() { inputForm.InputFromSubmitHeader, inputForm.InputFormNameHeader,
            inputForm.FirstName, inputForm.LastName, inputForm.Email, inputForm.Phone, inputForm.Address, inputForm.City, inputForm.State, inputForm.ZipCode,
            inputForm.WebsiteName, inputForm.DoYouHaveHosting, inputForm.ProjectDescription};

            var inputFormHeadersAndLabelsStringList = new List<string>() { "Input form with validations", "Contact Us Today!", "First Name", "Last Name",
            "E-Mail", "Phone #", "Address", "City", "State", "Zip Code", "Website or domain name", "Do you have hosting?", "Project Description"};

            VerifyElementList(inputFormHeadersAndLabelsWebElementList, inputFormHeadersAndLabelsStringList);

            inputForm.InputFirstName.SendKeys("Norah");
            inputForm.InputLastName.SendKeys("Lovelace");
            inputForm.InputEmail.SendKeys("test@email.com");
            inputForm.InputPhone.SendKeys("011-112-1123");
            inputForm.InputAddress.SendKeys("111 Orchard Road");
            inputForm.InputCity.SendKeys("St.Louis");
            inputForm.SelectState.Click();
            
            random = new Random();
            var randomState = random.Next(inputForm.SelectStateOptions.Count);
            var randomChosenState = inputForm.SelectStateOptions[randomState];
            Assert.IsTrue(inputForm.SelectState.Text.Contains(randomChosenState.Text),$"{randomChosenState.Text} is not matching with {randomChosenState}.");

            inputForm.InputZip.SendKeys("63101");
            inputForm.InputWebsite.SendKeys("www.Selenium.com");
            inputForm.InputDoYouHaveHosting[0].Click();
            inputForm.InputComment.SendKeys("Selenium Easy");
            inputForm.SubmitButton.Click();

            
        }
    }
}
