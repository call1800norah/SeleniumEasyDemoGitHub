using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyDemoGitHub.InputForms.Input_Form_Submit
{
    public class InputFormSubmitUnitTestPO
    {
        private IWebDriver _driver;
        public InputFormSubmitUnitTestPO(IWebDriver driver)
        {
            _driver = driver;
        }
        public InputFormSubmitUnitTestPO() { }

        public IWebElement InputFromSubmitHeader => _driver.FindElement(By.XPath("//h2[text()='Input form with validations']"));
        public IWebElement InputFormNameHeader => _driver.FindElement(By.XPath("//legend[text()='Contact Us Today!']"));
        public IWebElement FirstName => _driver.FindElement(By.XPath("//label[text()='First Name']"));
        public IWebElement LastName => _driver.FindElement(By.XPath("//label[text()='Last Name']"));
        public IWebElement Email => _driver.FindElement(By.XPath("//label[text()='E-Mail']"));
        public IWebElement Phone => _driver.FindElement(By.XPath("//label[text()='Phone #']"));
        public IWebElement Address => _driver.FindElement(By.XPath("//label[text()='Address']"));
        public IWebElement City => _driver.FindElement(By.XPath("//label[text()='City']"));
        public IWebElement State => _driver.FindElement(By.XPath("//label[text()='State']"));
        public IWebElement ZipCode => _driver.FindElement(By.XPath("//label[text()='Zip Code']"));
        public IWebElement WebsiteName => _driver.FindElement(By.XPath("//label[text()='Website or domain name']"));
        public IWebElement DoYouHaveHosting => _driver.FindElement(By.XPath("//label[text()='Do you have hosting?']"));
        public IWebElement ProjectDescription => _driver.FindElement(By.XPath("//label[text()='Project Description']"));
        public IWebElement InputFirstName => _driver.FindElement(By.XPath("//input[@name='first_name']"));
        public IWebElement InputLastName => _driver.FindElement(By.XPath("//input[@name='last_name']"));
        public IWebElement InputEmail => _driver.FindElement(By.XPath("//input[@name='email']"));
        public IWebElement InputPhone => _driver.FindElement(By.XPath("//input[@name='phone']"));
        public IWebElement InputAddress => _driver.FindElement(By.XPath("//input[@name='address']"));
        public IWebElement InputCity => _driver.FindElement(By.XPath("//input[@name='city']"));
        public IWebElement SelectState => _driver.FindElement(By.XPath("//select[@name='state']"));
        public ReadOnlyCollection<IWebElement> SelectStateOptions => _driver.FindElements(By.XPath("//select[@name='state']/option"));
        public IWebElement InputZip => _driver.FindElement(By.XPath("//input[@name='zip']"));
        public IWebElement InputWebsite => _driver.FindElement(By.XPath("//input[@name='website']"));
        public ReadOnlyCollection<IWebElement> InputDoYouHaveHosting => _driver.FindElements(By.XPath("//input[@name='hosting']"));
        public IWebElement InputComment => _driver.FindElement(By.XPath("//input[@name='comment']"));
        public IWebElement SubmitButton => _driver.FindElement(By.XPath("//button[@class='btn btn-default']"));





    }
}
