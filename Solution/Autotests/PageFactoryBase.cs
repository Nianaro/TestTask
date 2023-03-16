using System;
using OpenQA.Selenium;

namespace Autotests
{
    public static class PageFactoryBase
    {
        public static T Open<T>(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(UrlBuilder.GetUrl(typeof(T)));
            return CreatePage<T>(driver);
        }

        private static T CreatePage<T>(IWebDriver driver) => (T)Activator.CreateInstance(typeof(T), driver);

    }
}