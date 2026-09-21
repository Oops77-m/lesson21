using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace Test21.Page;

public class DynamicControlsPage : BasePage
{
    public DynamicControlsPage(IWebDriver driver) : base(driver)
    {

    }

    private readonly By checkBox = By.Id("checkbox");
    private readonly By textRemove = By.XPath("//*[text()=\"It's gone!\"]");
    private readonly By textInput = By.XPath("//*[text()=\"It's enabled!\"]");
    private readonly By input = By.CssSelector("input[type='text']");

    public void OpenDynamicControls()
    {
        _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_controls");
        _driver.Manage().Window.Maximize(); //увеличит окно
    }

    public bool IsCheckBoxDisplayed() //есть чекбокс
    {
        return _driver.FindElements(checkBox).Count > 0;
    }

    public void RemoveButton()
    {
        _driver.FindElement(By.CssSelector("*[onclick='swapCheckbox()']")).Click(); //кликнуть на кнопку чекбокса
    }

    public bool IsCheckBoxText()
    {
        return _driver.FindElement(textRemove).Displayed; // появился текст
    }
    public bool IsInputEnabled()
    {
        return _driver.FindElement(input).Enabled;
    }
    public void EnableButton()
    {
        _driver.FindElement(By.CssSelector("*[onclick='swapInput()']")).Click(); //кликнуть на кнопку 
    }
    public bool IsInputText()
    {
        return _driver.FindElement(textInput).Displayed; // появился текст
    }
}