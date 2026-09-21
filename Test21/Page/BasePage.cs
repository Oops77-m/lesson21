using OpenQA.Selenium;

namespace Test21.Page;

public class BasePage
{
    protected IWebDriver _driver;
    public  BasePage(IWebDriver driver)
    {
        _driver = driver;
    }
    public void OpenAlerts()
    {
        _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
        _driver.Manage().Window.Maximize(); //увеличит окно
    }
}