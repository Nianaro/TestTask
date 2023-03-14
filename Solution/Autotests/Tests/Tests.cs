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
        var rowTitle = googleResultsPage.GetRowTitle(4);
        Assert.That(rowTitle,
            Does.Contain("Can we export new ide selenium tests to C#"), "Fourth search result row doesn't contain text 'Selenium IDE'");
    }

    /*[Test]
    public void X2()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArguments("--start-maximized");

        IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);

        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        PageFactoryBase.Open<GoogleStartPage>(driver).Find("Selenium IDE export to C");

        //Thread.Sleep(30000);

        GoogleResultsPage googleResultsPage = new GoogleResultsPage(driver);
        Assert.That(googleResultsPage.GetRowTitle(4),
            Does.Contain("Can we export new ide selenium tests to C#"), "Fourth search result row doesn't contain text 'Selenium IDE'");
        
        driver.Quit();
    }*/
}