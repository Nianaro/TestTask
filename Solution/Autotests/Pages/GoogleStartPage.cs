using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Autotests.Pages
{
    [PageUrl("https://google.com")]
    public class GoogleStartPage : Page
    {
        public GoogleStartPage(IWebDriver driver) : base(driver) => PageFactory.InitElements(driver, this);

        internal void Find(string query)
        {
            SearchInput.SendKeys(query);
            SubmitButton.Click();
        }

        // Dynamic proxy objects
        // Search will be after invoke 'SearchInput.smth' but not after invoke 'PageFactory.InitElements'
        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement SearchInput;

        [FindsBy(How = How.Name, Using = "btnK")]
        private IWebElement SubmitButton;
    }
}