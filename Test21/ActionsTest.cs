using Test21.Page;

namespace Test21;

public class ActionsTest : BaseTest
{
    [Test]
    
    public void ActionTest()
    {
        ActionsPage actionsPage = new ActionsPage(driver);
        actionsPage.OpenDemoqa();
        Thread.Sleep(3000);
        actionsPage.DragAndDrop();
        Thread.Sleep(3000);
        Assert.That(actionsPage.IsDroppedText(), Is.True);
    }
}