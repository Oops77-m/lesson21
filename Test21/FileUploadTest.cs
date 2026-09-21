using Test21.Page;

namespace Test21;


public class FileUploadTest : BaseTest
{
    [Test]
    public void FileUpload()
    {
        FileUploadPage fileUploadPage = new FileUploadPage(driver);
        fileUploadPage.OpenDemoqaFile();
        Thread.Sleep(5000);
        fileUploadPage.FileInput();
        Thread.Sleep(5000);
        Assert.That(fileUploadPage.FileInputText(), Does.Contain("test.txt"));
    }
}