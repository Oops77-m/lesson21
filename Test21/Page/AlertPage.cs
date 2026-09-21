using OpenQA.Selenium;

namespace Test21.Page;

public class AlertPage : BasePage
{
   private readonly IWebElement _alert;
   private readonly By _btn0Click = By.XPath("//button[text()='Click for JS Alert']");
   private readonly By _btn0ClickConfirm=By.XPath("//button[text()='Click for JS Confirm']");
   private readonly By _btn0ClickPrompt=By.XPath("//button[text()='Click for JS Prompt']");
   private readonly By _lbResult = By.Id("result");
   public AlertPage(IWebDriver driver) : base(driver)
   {
      
   }

   public void ClickAletr()
   {
      _driver.FindElement(_btn0Click).Click();
   }
   public void ClickConfirm()
   {
      _driver.FindElement(_btn0ClickConfirm).Click();
   }
   public void ClickPrompt()
   {
      _driver.FindElement(_btn0ClickPrompt).Click();
   }
   public string GetAlertText()
   {
      return _driver.SwitchTo().Alert().Text;
   }

   public void AcceptAlert() // ОК
   {
      _driver.SwitchTo().Alert().Accept();
   }
   public void DismissAlert() //Закрыть
   {
      _driver.SwitchTo().Alert().Dismiss();
   }

   public void SendValuePrompt(string message)
   {
      _driver.SwitchTo().Alert().SendKeys(message);
   }
   public string GetResult()
   {
      return _driver.FindElement(_lbResult).Text;
   }
   
}