using OpenQA.Selenium;

namespace SeleniumEasyDemo.InputForms
{
    public class SimpleFormDemoUnitTestPO
    {
        private readonly IWebDriver _driver;
        public SimpleFormDemoUnitTestPO(IWebDriver driver)
        {
            _driver = driver;

        }
        public SimpleFormDemoUnitTestPO() { }

        //SIngle Input Field
        public IWebElement SingleInputFieldHeading => _driver.FindElement(By.XPath("//div[@class='panel-heading' and text()='Single Input Field']"));
        public IWebElement ImageDarkener => _driver.FindElement(By.XPath("//div[@id='image-darkener']"));
        public IWebElement ImageCloseButton => _driver.FindElement(By.XPath("//a[@id='at-cv-lightbox-close']"));

        public IWebElement EnterMessageLabel => _driver.FindElement(By.XPath("//label[@for='message' and text()='Enter message']"));
        public IWebElement InputMessageBox => _driver.FindElement(By.XPath("//input[@id='user-message']"));
        public IWebElement ShowMessageButton => _driver.FindElement(By.XPath("//button[@onclick='showInput();']"));
        public IWebElement YourMessageLabel => _driver.FindElement(By.XPath("//div[@id='user-message']/label"));
        public IWebElement MessageDisplay => _driver.FindElement(By.XPath("//div[@id='user-message']/span[@id='display']"));

        //Two Input Field
        public IWebElement EnteraLabel => _driver.FindElement(By.XPath("//label[@for='value1']"));
        public IWebElement EnterbLabel => _driver.FindElement(By.XPath("//label[@for='value2']"));
        public IWebElement TotalLabel => _driver.FindElement(By.XPath("//label[text()=' Total a + b = ']"));
        public IWebElement InputA => _driver.FindElement(By.XPath("//input[@id= 'sum1']"));
        public IWebElement InputB => _driver.FindElement(By.XPath("//input[@id= 'sum2']"));
        public IWebElement GetTotalButton => _driver.FindElement(By.XPath("//button[@onclick='return total()']"));
        public IWebElement DisplayValue => _driver.FindElement(By.XPath("//span[@id='displayvalue']"));
    }
}