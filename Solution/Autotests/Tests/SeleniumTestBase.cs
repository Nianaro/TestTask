using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Autotests
{
    internal abstract class SeleniumTestBase
    {
        protected IWebDriver BrowserDriver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized");

            BrowserDriver = new ChromeDriver(options);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() => BrowserDriver.Quit();
    }
}