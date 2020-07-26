using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace Autotests.Pages
{
    internal class GoogleResultsPage : Page
    {
        internal GoogleResultsPage(IWebDriver browserDriver) : base(browserDriver) => PageFactory.InitElements(browserDriver, this);

        internal string GetRowTitle(int row) => SearchResults[row].FindElement(By.XPath(".//h3")).Text;
       

        [FindsBy(How = How.XPath, Using = ".//*[@id='rso']/div[@class='g']")]
        private IList<IWebElement> SearchResults;
    }
}