using OpenQA.Selenium;

namespace Autotests.Pages
{
    internal abstract class Page
    {
        protected IWebDriver BrowserDriver;
        internal Page(IWebDriver browserDriver) 
        {
            BrowserDriver = browserDriver;
        }
    }
}
