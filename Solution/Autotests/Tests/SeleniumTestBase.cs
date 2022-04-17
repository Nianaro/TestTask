using System;
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
            
            BrowserDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() => BrowserDriver.Quit();
    }
}