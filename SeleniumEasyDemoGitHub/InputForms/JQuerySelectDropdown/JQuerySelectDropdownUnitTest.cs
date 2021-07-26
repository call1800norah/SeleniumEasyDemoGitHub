using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumEasyDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyDemoGitHub.InputForms.JQuerySelectDropdown
{
    [TestClass]
    public class JQuerySelectDropdownUnitTest : UnitTestBase
    {
        private JQuerySelectDropdownUnitTestPO jQuerySelect;

        [TestMethod]
        public void JQuerySelectUnitTest()
        {
            jQuerySelect = new JQuerySelectDropdownUnitTestPO(driver);
            //Method for closing Image popup
            ImageCloseMethod("JQuery Select dropdown");

            var jQuerySelectHeadersAndLabelsWebElementList = new List<IWebElement>() { jQuerySelect.DropdownWithSearchboxHeader, jQuerySelect.SelectCountryLabel,
            jQuerySelect.MultiSelectHeader, jQuerySelect.SelectMultiValuesHeader, jQuerySelect.SelectStateLabel, jQuerySelect.DropdownWithDisabledValuesHeader,
            jQuerySelect.SelectUsTerritoriesLabel, jQuerySelect.DropdownWIthCategoryHeader, jQuerySelect.SelectAFileLabel};

            var JQuerySelectHeaderAndLabelsStringList = new List<string>() { "Drop Down with Search box", "Select Country :",
                "Multi Select - Search and Select multiple states", "Select Multiple Values", "Select State :", "Drop Down with Disabled values",
            "Select US Outlying Territories :", "Drop-down with Category related options", "Select a file"};

            VerifyElementList(jQuerySelectHeadersAndLabelsWebElementList, JQuerySelectHeaderAndLabelsStringList);

        }
        

    }
}
