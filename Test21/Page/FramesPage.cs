using OpenQA.Selenium;

namespace Test21.Page;

public class FramesPage
{
    protected IWebDriver _driver;
    public  FramesPage(IWebDriver driver)
    {
        _driver = driver;
    }
    
    public void OpenFrames()
    {
        _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/nested_frames");
        _driver.Manage().Window.Maximize(); //увеличит окно
    }

    public string SwitchToLeftFrame()
    {
        var topFrame = _driver.FindElement(By.XPath("//frame[@name='frame-top']"));
        _driver.SwitchTo().Frame(topFrame);
        _driver.SwitchTo().Frame("frame-left");
        return _driver.FindElement(By.XPath("//html")).Text;
    }

    public string SwitchToParentFrame()
    {
        _driver.SwitchTo().ParentFrame();
        return _driver.PageSource; //FindElement(By.XPath("//html")).Text;
    }
    public string SwitchToDefaultContent()
    {
        _driver.SwitchTo().DefaultContent();
        return _driver.PageSource;
    }
}