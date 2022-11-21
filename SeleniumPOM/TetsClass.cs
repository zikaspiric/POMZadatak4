using NUnit.Framework;
using SeleniumPOM.Driver;
using SeleniumPOM.Page;

namespace SeleniumPOM;

public class TestClass
{
    private LoginPage _loginPage;
    private HomePage _homePage;

    [SetUp]

    public void BeforeScenario()
    {
        WebDriver.Initialize();
        _loginPage = new LoginPage();
        _homePage = new HomePage();

    }

    [TearDown]
    public void AfterScenario()
    {
        //WebDriver.CleanUp();
    }


  

    [Test]
    public void TC01_OpenPopUp_ShouldDisplayed()
    {
        Login("standard_user", "secret_sauce");
        //_homePage.HtmlPopup.Click();


    
    }
    [Test]
    public void TC02_FillInputWithValidData_ShouldAllDataDisplayedInInput()
    {

        Login("standard_user", "secret_sauce");

        _homePage.Img4.Click();
        _homePage.AddButton.Click();
        _homePage.BackButton.Click();
    }





    public void Login(string name, string pass)
    {
        _loginPage.LoginOnPage(name, pass);
    }
}
