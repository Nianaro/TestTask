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

            /*options.AddAdditionalCapability("enableVNC", true, true);

            Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);*/
            Driver = new ChromeDriver(options);

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() => Driver.Quit();
    }
}