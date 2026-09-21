using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test21.Page;


namespace Test21;


public class BaseTest
{
    public IWebDriver driver;
    [SetUp]
    public void Test1()
    {
        var options = new ChromeOptions();
        options.AddUserProfilePreference("download.default_directory", @"C:\Users\petys\Downloads");
        options.AddUserProfilePreference("download.prompt_for_download", false);
        driver = new ChromeDriver();
        var basePage = new BasePage(driver);
        basePage.OpenAlerts();
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
        driver.Dispose();
    }
    

}