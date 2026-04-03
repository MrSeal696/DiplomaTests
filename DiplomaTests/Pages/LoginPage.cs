using OpenQA.Selenium;

public class LoginPage
{
    private IWebDriver driver;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    private IWebElement Username => driver.FindElement(By.Id("username"));
    private IWebElement Password => driver.FindElement(By.Id("password"));
    private IWebElement LoginButton => driver.FindElement(By.CssSelector("button[type='submit']"));

    public void EnterUsername(string username)
    {
        Username.SendKeys(username);
    }

    public void EnterPassword(string password)
    {
        Password.SendKeys(password);
    }

    public void ClickLogin()
    {
        LoginButton.Click();
    }
}