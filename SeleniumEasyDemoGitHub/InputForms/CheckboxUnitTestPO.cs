using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyDemoGitHub.InputForms
{
    public class CheckboxUnitTestPO
    {
        public IWebDriver _driver;
        public CheckboxUnitTestPO(IWebDriver driver)
        {
            _driver = driver;
        }
        //Single Checkbox Demo
        public IWebElement SingleCheckboxHeader => _driver.FindElement(By.XPath("//div[@class='panel-heading' and text()='Single Checkbox Demo']"));
        public IWebElement SingleCheckboxMessage => _driver.FindElement(By.XPath("//div[@class='panel-body']//p[text()=' Clicking on the checkbox will display a success message. Keep an eye on it']"));
        public IWebElement SingleCheckboxClick => _driver.FindElement(By.XPath("//input[@id='isAgeSelected']"));
        public IWebElement CheckboxCheckedMessage => _driver.FindElement(By.XPath("//div[@id='txtAge']"));

        //Multiple checkbox Demo
        public IWebElement MultiCheckboxHeader => _driver.FindElement(By.XPath("//div[@class='panel-heading' and text()='Multiple Checkbox Demo']"));
        public IWebElement MultiCheckboxMessage => _driver.FindElement(By.XPath("//div[@class='panel-body']//p[text()='Check the below points before automating']"));
        public ReadOnlyCollection<IWebElement> MultiCheckboxMessages => _driver.FindElements(By.XPath("//div[@class='col-md-6 text-left']//ul//li"));
        public ReadOnlyCollection<IWebElement> CheckboxOptions => _driver.FindElements(By.XPath("//div[@class='checkbox']//input[@class='cb1-element']"));
        public IWebElement CheckAllButton => _driver.FindElement(By.XPath("//input[@id='check1' and @value='Check All']"));

    }
}
