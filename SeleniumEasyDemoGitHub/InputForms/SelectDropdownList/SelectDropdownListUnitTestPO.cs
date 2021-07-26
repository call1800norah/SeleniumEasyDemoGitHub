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

        //Select List Demo
        public IWebElement SelectListDemoHeader => _driver.FindElement(By.XPath("//div[@class='panel-heading' and text()='Select List Demo']"));
        public IWebElement SelectListDemoBody => _driver.FindElement(By.XPath("//div[@class='panel-body']/p[ text()='Selected value from the list will display below the dropdown']"));
        public IWebElement SelectAdayLabel => _driver.FindElement(By.XPath("//div[@class='panel-body']//following::label"));
        public IWebElement SelectAdayClick => _driver.FindElement(By.XPath("//select[@id='select-demo']"));
        public ReadOnlyCollection<IWebElement> SelectAdayDropdownOptions => _driver.FindElements(By.XPath("//select[@id='select-demo']/option"));
        public IWebElement DaySelected => _driver.FindElement(By.XPath("//*[@class='selected-value']"));

        //Nulti Select List Demo
        public IWebElement MultiSelectListDemoHeader => _driver.FindElement(By.XPath("//div[@class='panel-heading' and text()='Multi Select List Demo']"));
        public IWebElement MultiSelectListParagraph => _driver.FindElement(By.XPath("//p[text()='By clicking on the buttons, you can get value from the list which will display just below the buttons']"));
        public IWebElement FirstSelectedButton => _driver.FindElement(By.XPath("//button[@ID='printMe']"));
        public IWebElement GetAllSelectedButton => _driver.FindElement(By.XPath("//button[@ID='printAll']"));
        public ReadOnlyCollection<IWebElement> MultiSelectOptions => _driver.FindElements(By.XPath("//select[@id='multi-select']/option"));
        public IWebElement SelectedOptionResult => _driver.FindElement(By.XPath("//p[@class='getall-selected']"));





    }
}
