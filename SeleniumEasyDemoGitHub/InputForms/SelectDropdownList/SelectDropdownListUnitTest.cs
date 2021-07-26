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
    public class SelectDropdownListUnitTest : UnitTestBase
    {
        private SelectDropdownListUnitTestPO selectDropdown;
        private Random random;

        [TestMethod]
        public void SelectListDemoUnitTest()
        {
            //Method for closing Image popup
            ImageCloseMethod("Select Dropdown List");

            selectDropdown = new SelectDropdownListUnitTestPO(driver);

            var SelectListWebElementLabels = new List<IWebElement>() { selectDropdown.SelectListDemoHeader, selectDropdown.SelectListDemoBody,
            selectDropdown.SelectAdayLabel};
            var SelectListStringLabels = new List<string>(){ "Select List Demo", "Selected value from the list will display below the dropdown",
            "Select a day (select one):"};

            VerifyElementList(SelectListWebElementLabels, SelectListStringLabels);

            var selectDropdownOptions = new List<string>() { "Please select", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            VerifyElementCollection(selectDropdown.SelectAdayDropdownOptions, selectDropdownOptions);

            selectDropdown.SelectAdayClick.Click();

            random = new Random();
            int randomOption = 0;
            do
            {
                randomOption = random.Next(selectDropdownOptions.Count);
                var selectedOption = selectDropdown.SelectAdayDropdownOptions[randomOption];
                selectedOption.Click();
                Assert.IsTrue(selectDropdown.DaySelected.Text.Trim().Contains(selectedOption.Text.Trim()));

            } while (randomOption.Equals(0));                    
        }
        [TestMethod]
        public void MultiSelectListDemoUnitTest()
        {
            //Method for closing Image popup
            ImageCloseMethod("Select Dropdown List");

            selectDropdown = new SelectDropdownListUnitTestPO(driver);

            var headerAndParagraphWebElementList = new List<IWebElement>() { selectDropdown.MultiSelectListDemoHeader, selectDropdown.MultiSelectListParagraph };
            var headerAndParagraphStringList = new List<string>() { "Multi Select List Demo",
                "By clicking on the buttons, you can get value from the list which will display just below the buttons" };
            VerifyElementList(headerAndParagraphWebElementList, headerAndParagraphStringList);

            var statesList = new List<string>() { "California", "Florida", "New Jersey", "New York", "Ohio", "Texas", "Pennsylvania", "Washington" };
            VerifyElementCollection(selectDropdown.MultiSelectOptions, statesList);

            random = new Random();
            var randomOption = random.Next(selectDropdown.MultiSelectOptions.Count);
            var randomChosenOption = selectDropdown.MultiSelectOptions[randomOption];
            randomChosenOption.Click();
            selectDropdown.FirstSelectedButton.Click();
            
            Assert.IsTrue(selectDropdown.SelectedOptionResult.Text.Trim().Contains(randomChosenOption.Text.Trim()));
            selectDropdown.GetAllSelectedButton.Click();
            Assert.IsTrue(selectDropdown.SelectedOptionResult.Text.Trim().Contains(randomChosenOption.Text.Trim()));

        }
    }
}
