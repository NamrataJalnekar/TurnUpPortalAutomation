using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnIUpPortalAutomation.Pages
{
    public class HomePage
    {
        public void GoToTimePage(IWebDriver driver)
        {
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();

            // click creatre new record
            IWebElement timeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeOption.Click();
        }
    }
}
