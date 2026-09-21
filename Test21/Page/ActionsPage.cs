using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Test21.Page;

public class ActionsPage : BasePage
{
    public ActionsPage(IWebDriver driver) : base(driver)
    {

    }
    private By dragMe = By.Id("draggable"); 
    private By dropHere = By.Id("droppable");
    public void OpenDemoqa()
    {
        _driver.Navigate().GoToUrl("https://demoqa.com/droppable");
        _driver.Manage().Window.Maximize(); //увеличит окно
    }

    public void DragAndDrop()
    {
        var source = _driver.FindElement(dragMe);
        var target = _driver.FindElement(dropHere);

        Actions actionsPage = new Actions(_driver);
        actionsPage.DragAndDrop(source, target).Perform();
    }

    public bool IsDroppedText()
    {
        return _driver.FindElement(By.XPath("//p[text()='Dropped!']")).Displayed;
    }
}