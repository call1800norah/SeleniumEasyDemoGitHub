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

        //Radio Button Demo
        public IWebElement RadioButtonDemoHeader => _driver.FindElement(By.XPath("//div[@class='panel-heading' and text()='Radio Button Demo']"));
        public IWebElement RadioButtonDemoMessage => _driver.FindElement(By.XPath("//div[@class='panel-body']/p[text()='Click on button to get the selected value']"));
        public ReadOnlyCollection<IWebElement> RadioButtonOptions => _driver.FindElements(By.XPath("//label[@class='radio-inline']/input[@name='optradio']"));
        public IWebElement GetCheckedValueButton => _driver.FindElement(By.XPath("//button[@id='buttoncheck']"));
        public IWebElement ButtonCheckedIndicator => _driver.FindElement(By.XPath("//p[@class='radiobutton']"));

        //Group Radio Buttons Demo
        public IWebElement GroupRadioButtonsDemoHeader => _driver.FindElement(By.XPath("//div[@class='panel-heading' and text()='Group Radio Buttons Demo']"));
        public IWebElement GroupRadioButtonsDemoMessage => _driver.FindElement(By.XPath("//div[@class='panel-body']/p[text()='Click on button to get the selected values from Group Sex and Age group']"));
        public IWebElement GenderLabel => _driver.FindElement(By.XPath("//h4[text()='Sex : ']"));
        public IWebElement AgeGroupLabel => _driver.FindElement(By.XPath("//h4[text()='Age Group : ']"));
        public ReadOnlyCollection<IWebElement> GenderOptions => _driver.FindElements(By.XPath("//label[@class='radio-inline']/input[@name='gender']"));
        public ReadOnlyCollection<IWebElement> AgeOptions => _driver.FindElements(By.XPath("//label[@class='radio-inline']/input[@name='ageGroup']"));
        public IWebElement GetValuesButton => _driver.FindElement(By.XPath("//button[@onclick='getValues();' and text()='Get values']"));
        public IWebElement ValueOutput => _driver.FindElement(By.XPath("//p[@class='groupradiobutton']"));


    }
}
