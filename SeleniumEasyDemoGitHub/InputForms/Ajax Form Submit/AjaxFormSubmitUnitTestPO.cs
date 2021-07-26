using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyDemoGitHub.InputForms.Ajax_Form_Submit
{
    public class AjaxFormSubmitUnitTestPO
    {
        private IWebDriver _driver;

        public AjaxFormSubmitUnitTestPO(IWebDriver driver)
        {
            _driver = driver;
        }
        public AjaxFormSubmitUnitTestPO() { }
        public IWebElement AjaxFormHeader => _driver.FindElement(By.XPath("//div[@class='panel-heading' and text()='Ajax Form']"));
        public IWebElement NameLabel => _driver.FindElement(By.XPath("//label[@for='usr']"));
        public IWebElement CommentLabel => _driver.FindElement(By.XPath("//label[@for='comment']"));
        public IWebElement SubmitButton => _driver.FindElement(By.XPath("//input[@id='btn-submit']"));
        public IWebElement InputName => _driver.FindElement(By.XPath("//input[@id='title']"));
        public IWebElement InputComment => _driver.FindElement(By.XPath("//textarea[@id='description']"));
        public IWebElement SubmitSuccessMessage => _driver.FindElement(By.XPath("//div[@id='submit-control']"));




    }
}
