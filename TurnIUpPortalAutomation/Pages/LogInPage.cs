using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnIUpPortalAutomation.Pages
{
    public class LogInPage
    {
        public void logInActions(IWebDriver driver)
        {
            
            driver.Manage().Window.Maximize();

            //launch turn up portal and navigate to login
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //identify username textbox and enter valid username
            IWebElement userNameTextbox = driver.FindElement(By.Id("UserName"));
            userNameTextbox.SendKeys("hari");

            //identify password textbox and enter valid password
            IWebElement userPassword = driver.FindElement(By.Id("Password"));
            userPassword.SendKeys("123123");

            //identify login button and press it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            //check if user has been logged in sucessfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("user logged in successfully");

            }
            else
            {
                Console.WriteLine("user loggied in unsuccessful");
            }
        }
    }
}
