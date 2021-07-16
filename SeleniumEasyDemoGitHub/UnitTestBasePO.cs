using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyDemoGitHub
{
    public class UnitTestBasePO
    {
        private IWebDriver _driver;
        public UnitTestBasePO(IWebDriver driver)
        {
            _driver = driver;
        }
        public UnitTestBasePO() { }
        public IWebElement MenuListHeader => _driver.FindElement(By.XPath("//div[@class='col-md-3 sidenav']//div[@class='panel-heading']"));
        public IWebElement AllExamplesNavBar => _driver.FindElement(By.XPath("//ul[@id='treemenu']//a[@href='#' and text()='All Examples']"));
        public IWebElement InputFormsNavBar => _driver.FindElement(By.XPath("//ul[@id='treemenu']//a[@href='#' and text()='Input Forms']"));
        public ReadOnlyCollection<IWebElement> InputFormsItems => _driver.FindElements(By.XPath("//li[@class='tree-branch']//a[@href='#' and text()='Input Forms']//following::ul//li[@style='display: list-item;']"));


    }
}
