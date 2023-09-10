using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnIUpPortalAutomation.Uitilities
{
    public class Wait
    {
        public static void WaitToClickble(IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions)
        }
    }
}
