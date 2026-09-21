using OpenQA.Selenium;

namespace Test21.Page;

public class FileDownloadPage : BasePage
{
    private readonly By file = By.Id("downloadButton");
    
    public FileDownloadPage(IWebDriver driver) : base(driver)
    {

    }
    public void OpenDemoqaFile2()
    {
        _driver.Navigate().GoToUrl("https://demoqa.com/upload-download");
        _driver.Manage().Window.Maximize(); //увеличит окно
    }

    public void DownloadFile()
    {
        _driver.FindElement(file).Click();
    }

    public string GetFileName()
    {
        return "sampleFile.jpeg";
    }
}