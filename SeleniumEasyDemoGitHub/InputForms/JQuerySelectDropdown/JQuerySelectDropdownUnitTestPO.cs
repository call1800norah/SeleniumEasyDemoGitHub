using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyDemoGitHub.InputForms.JQuerySelectDropdown
{
    public class JQuerySelectDropdownUnitTestPO
    {
        private IWebDriver _driver;

        public JQuerySelectDropdownUnitTestPO(IWebDriver driver)
        {
            _driver = driver;
        }
        public JQuerySelectDropdownUnitTestPO() { }

        public IWebElement SingleSelectHeader => _driver.FindElement(By.XPath("//h2[text()='Single Select - Search and Select country']"));
        public IWebElement DropdownWithSearchboxHeader => _driver.FindElement(By.XPath("//h3[@class='panel-title' and text()='Drop Down with Search box']"));
        public IWebElement SelectCountryLabel => _driver.FindElement(By.XPath("//label[text()='Select Country :']"));
        public IWebElement MultiSelectHeader => _driver.FindElement(By.XPath("//h3[text()='Multi Select - Search and Select multiple states']"));
        public IWebElement SelectMultiValuesHeader => _driver.FindElement(By.XPath("//h3[text()=' Select Multiple Values']"));
        public IWebElement SelectStateLabel => _driver.FindElement(By.XPath("//label[text()='Select State :']"));
        public IWebElement DropdownWithDisabledValuesHeader => _driver.FindElement(By.XPath("//h3[text()='Drop Down with Disabled values']"));
        public IWebElement SelectUsTerritoriesLabel => _driver.FindElement(By.XPath("//label[text()='Select US Outlying Territories :']"));
        public IWebElement SelectAFileLabel => _driver.FindElement(By.XPath("//label[text()='Select a file']"));
        public IWebElement DropdownWIthCategoryHeader => _driver.FindElement(By.XPath("//h3[text()='Drop-down with Category related options']"));


    }
}
