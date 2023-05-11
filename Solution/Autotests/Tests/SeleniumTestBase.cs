using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace Autotests
{
    public abstract class SeleniumTestBase
    {
        protected IWebDriver Driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();
            var env = config["ApplicationSetting:Environment"];

            var options = new ChromeOptions();
            options.AddArguments("--start-maximized");

            if (env == "Local")
            { 
                Driver = new ChromeDriver(options);
            }
            else if (env == "Remote") 
            {
                //options.AddAdditionalCapability("enableVNC", true, true);

                Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
            }

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() => Driver.Quit();
    }
}