using Test21.Page;

namespace Test21;

[TestFixture]
public class JavaScriptTest : BaseTest
{
    [Test]
    public void JSTest()
    {
        
        
        JavaScriptPage javaScriptPage = new JavaScriptPage(driver);
        javaScriptPage.OpenJScript();
        Thread.Sleep(2000);
        javaScriptPage.ScrollToLastOption();
        Thread.Sleep(2000);
        javaScriptPage.ClickLastOption();
        Thread.Sleep(10000);
        javaScriptPage.HideFrame();
        Thread.Sleep(10000);
    }
}