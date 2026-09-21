using OpenQA.Selenium;

namespace Test21.Page;

public class FileUploadPage : BasePage
{
    public FileUploadPage(IWebDriver driver) : base(driver)
    {

    }
    private readonly By fileInput = By.Id("uploadFile");
  
    
    public void OpenDemoqaFile()
    {
        _driver.Navigate().GoToUrl("https://demoqa.com/upload-download");
        _driver.Manage().Window.Maximize(); //увеличит окно
    }

    public void FileInput()
    {
        var input = _driver.FindElement(fileInput);
        input.SendKeys(@"C:\1\test.txt");
    }

    public string FileInputText()
    {
        return _driver.FindElement(By.Id("uploadedFilePath")).Text;
    }
    
}