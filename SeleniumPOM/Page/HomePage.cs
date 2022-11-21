using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriver = SeleniumPOM.Driver.WebDriver;

namespace SeleniumPOM.Page;

public class HomePage
{
    private IWebDriver driver = WebDriver.Instance;

   
    public IWebElement Img4 => driver.FindElement(By.Id("item_4_img_link"));
    public IWebElement AddButton => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
    public IWebElement BackButton => driver.FindElement(By.Id("back-to-products"));
    //public IWebElement HtmlPopup => driver.FindElement(By.LinkText("Click"));
    

    public void Title(string option)
    {
        SelectElement drop = new SelectElement(driver.FindElement(By.Id("TitleId")));
        drop.SelectByText(option);
    }

    
    public void Alert()
    {
        
        driver.SwitchTo().Alert().Accept();
    }


}
