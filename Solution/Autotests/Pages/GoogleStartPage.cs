using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Autotests.Pages
{
    internal class GoogleStartPage : Page
    {
        internal GoogleStartPage(IWebDriver browserDriver) : base(browserDriver) => PageFactory.InitElements(browserDriver, this);

        internal void Open() => BrowserDriver.Navigate().GoToUrl("https://google.com");

        internal void Find(string query)
        {
            SearchInput.SendKeys(query);
            SubmitButton.Click();
        }

        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement SearchInput;

        [FindsBy(How = How.Name, Using = "btnK")]
        private IWebElement SubmitButton;
    }
}