using Test21.Page;

namespace Test21;

[TestFixture]
public class DynamicControlsTest : BaseTest
{
    [Test]
    public void DynamicControls()
    {
        DynamicControlsPage dynamicControlsPage = new DynamicControlsPage(driver);
        dynamicControlsPage.OpenDynamicControls();
        Thread.Sleep(2000);
        Assert.That(dynamicControlsPage.IsCheckBoxDisplayed(), Is.True);
        dynamicControlsPage.RemoveButton();
        Thread.Sleep(10000);
        Assert.That(dynamicControlsPage.IsCheckBoxText(), Is.True);
        Assert.That(dynamicControlsPage.IsCheckBoxDisplayed(), Is.False);
        
        Assert.That(dynamicControlsPage.IsInputEnabled(), Is.False);
        dynamicControlsPage.EnableButton();
        Thread.Sleep(10000);
        Assert.That(dynamicControlsPage.IsInputText(), Is.True);
        Assert.That(dynamicControlsPage.IsInputEnabled(), Is.True);
        
    }
}