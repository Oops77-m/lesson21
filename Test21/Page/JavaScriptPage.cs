using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Test21.Page;

public class JavaScriptPage : BasePage
{
    private readonly By lnkBotton = By.LinkText("WYSIWYG Editor");
    public JavaScriptPage(IWebDriver driver) : base(driver)
    {
        
    }

    public void OpenJScript()
    {
        _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com");
        _driver.Manage().Window.Maximize(); //увеличит окно
    }
    public void ScrollToLastOption()
    {
        var btnBotton = _driver.FindElement(lnkBotton);
        var jsExecutor = (IJavaScriptExecutor)_driver;
        jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", btnBotton);
    }

    public void ClickLastOption()
    {
        var btnBotton = _driver.FindElement(lnkBotton);
        ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", btnBotton);
    }
    public void HideFrame() // скрыть, если есть что скрывать
    {
        //((IJavaScriptExecutor)_driver).ExecuteScript("document.getElementsByTagName('iframe').style.display='none';");
        var frames = _driver.FindElements(By.TagName("frame"));
    
        if (frames.Count == 0)
        {
            Console.WriteLine("⚠️ На странице нет <frame> — пропускаем");
            return;
        }
    
        foreach (var frame in frames)
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript(
                "arguments[0].style.display='none';", frame);
        }
        
    }
    
}