using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyDemoGitHub.InputForms
{
    public class RadioButtonsDemoUnitTestPO
    {
        private IWebDriver _driver;
        public RadioButtonsDemoUnitTestPO(IWebDriver driver)
        {
            _driver = driver;
        }
        public RadioButtonsDemoUnitTestPO() { }
        public IWebElement RadioButtonDemoHeader => _driver.FindElement(By.XPath("//div[@class='panel-heading' and text()='Radio Button Demo']"));
        public IWebElement RadioButtonDemoMessage => _driver.FindElement(By.XPath("//div[@class='panel-body']/p[text()='Click on button to get the selected value']"));
        public ReadOnlyCollection<IWebElement> RadioButtonOptions => _driver.FindElements(By.XPath("//*[@id='easycont']/div/div[2]/div[1]/div[2]/label/text()"));
        public IWebElement GetCheckedValueButton => _driver.FindElement(By.XPath("//button[@id='buttoncheck']"));
        public IWebElement ButtonCheckedIndicator => _driver.FindElement(By.XPath("//p[@class='radiobutton']"));

    }
}
