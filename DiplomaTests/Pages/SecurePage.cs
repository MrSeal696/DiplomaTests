using OpenQA.Selenium;

public class SecurePage
{
    private IWebDriver driver;

    public SecurePage(IWebDriver driver)
    {
        this.driver = driver;
    }

    private IWebElement Message => driver.FindElement(By.Id("flash"));

    public bool IsLoginSuccessful()
    {
        return Message.Text.Contains("You logged into a secure area!");
    }
}