using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Autotests
{
    internal abstract class SeleniumTestBase
    {
        protected IWebDriver Driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized");

            Driver = new ChromeDriver(options);
            
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() => Driver.Quit();
    }
}