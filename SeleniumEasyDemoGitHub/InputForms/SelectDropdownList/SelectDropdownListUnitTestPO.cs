using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyDemoGitHub.InputForms
{
    public class SelectDropdownListUnitTestPO
    {
        public IWebDriver _driver;
        public SelectDropdownListUnitTestPO(IWebDriver driver)
        {
            _driver = driver;
        }
        public SelectDropdownListUnitTestPO() { }

        public IWebElement SelectListDemoHeader => _driver.FindElement(By.XPath("//div[@class='panel-heading' and text()='Select List Demo']"));
        public IWebElement SelectListDemoBody => _driver.FindElement(By.XPath("//div[@class='panel-body']/p[ text()='Selected value from the list will display below the dropdown']"));
        public IWebElement SelectAdayLabel => _driver.FindElement(By.XPath("//div[@class='panel-body']//following::label"));
        public IWebElement SelectAdayClick => _driver.FindElement(By.XPath("//select[@id='select-demo']"));
        public ReadOnlyCollection<IWebElement> SelectAdayDropdownOptions => _driver.FindElements(By.XPath("//select[@id='select-demo']/option"));
        public IWebElement DaySelected => _driver.FindElement(By.XPath("//*[@class='selected-value']"));


    }
}
