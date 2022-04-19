using Autotests.Pages;
using NUnit.Framework;

namespace Autotests;

[Parallelizable(ParallelScope.All)]
internal class Tests : SeleniumTestBase
{
    [Test]
    public void ThereIsSeleniumIdePhraseOnFourthRow()
    {
        PageFactoryBase.Open<GoogleStartPage>(Driver).Find("Selenium IDE export to C");

        GoogleResultsPage googleResultsPage = new GoogleResultsPage(Driver);
        Assert.That(googleResultsPage.GetRowTitle(4),
            Does.Contain("Can we export new ide selenium tests to C#"), "Fourth search result row doesn't contain text 'Selenium IDE'");
    }
}