using OpenQA.Selenium;

namespace Autotests.Pages
{
    public abstract class Page
    {
        protected IWebDriver Driver;
        internal Page(IWebDriver driver) 
        {
            Driver = driver;
        }
    }
}