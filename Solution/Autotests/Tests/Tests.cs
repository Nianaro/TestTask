using Autotests.Pages;
using NUnit.Framework;

namespace Autotests
{
    internal class Tests : SeleniumTestBase
    {
        [Test]
        public void ThereIsSeleniumIdePhraseOnFourthRow()
        {
            GoogleStartPage googleStartPage = new GoogleStartPage(BrowserDriver);
            googleStartPage.Open();
            googleStartPage.Find("Selenium IDE export to C");

            GoogleResultsPage googleResultsPage = new GoogleResultsPage(BrowserDriver);
            Assert.That(googleResultsPage.GetRowTitle(4),
                        Does.Contain("Selenium IDE"), "Fourth search result row doesn't contain text 'Selenium IDE'");
        }
    }
}