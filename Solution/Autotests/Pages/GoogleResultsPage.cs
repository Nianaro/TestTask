using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace Autotests.Pages
{
    public class GoogleResultsPage : Page
    {
        public GoogleResultsPage(IWebDriver driver) : base(driver) => PageFactory.InitElements(driver, this);

        internal string GetRowTitle(int row) => SearchResults[row - 1].FindElement(By.XPath(".//h3")).Text;
       

        [FindsBy(How = How.XPath, Using = ".//*[@id='rso']/div[contains(@class,'g')]")]
        private IList<IWebElement> SearchResults;
    }
}