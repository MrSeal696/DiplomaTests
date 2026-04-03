using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Запуск теста...");

        IWebDriver driver = new ChromeDriver();

        try
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            var loginPage = new LoginPage(driver);
            var securePage = new SecurePage(driver);


            loginPage.EnterUsername("tomsmith");
            loginPage.EnterPassword("SuperSecretPassword!");
            loginPage.ClickLogin();

            Thread.Sleep(2000); 


            if (securePage.IsLoginSuccessful())
            {
                Console.WriteLine("Тест пройден ");
            }
            else
            {
                Console.WriteLine("Тест провален ");
            }

            Console.WriteLine("URL после логина: " + driver.Url);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        finally
        {
            Thread.Sleep(3000); 
            driver.Quit();
        }
    }
}