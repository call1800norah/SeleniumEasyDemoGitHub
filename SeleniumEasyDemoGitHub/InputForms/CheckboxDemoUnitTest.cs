using OpenQA.Selenium;
using SeleniumEasyDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyDemoGitHub.InputForms
{
    public class CheckboxDemoUnitTest : UnitTestBase
    {
        private CheckboxUnitTestPO checkboxUnitTestPO;
        public void SingleCheckboxDemo()
        {
            checkboxUnitTestPO = new CheckboxUnitTestPO(driver);
            var HeaderList = new List<IWebElement>() { checkboxUnitTestPO.SingleCheckboxHeader, 
                checkboxUnitTestPO.MultiCheckboxHeader, checkboxUnitTestPO.MultiCheckboxMessage,
            checkboxUnitTestPO.SingleCheckboxMessage};
            ElementList(HeaderList);
            CollectionElement(checkboxUnitTestPO.CheckboxOptions);
            CollectionElement(checkboxUnitTestPO.MultiCheckboxMessages);


        }
    }
}
