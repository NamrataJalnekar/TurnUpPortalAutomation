using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnIUpPortalAutomation.Pages;
using TurnIUpPortalAutomation.Uitilities;

namespace TurnIUpPortalAutomation.Tests
{
    [Parallelizable]
    [TestFixture]
    public class TM_Test : CommonDriver
    {
        [SetUp]
        public void SetUpTM()
        {
            //Open the browser
             driver = new ChromeDriver();

           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //login Page intialization
            LogInPage loginpageobj = new LogInPage();
            loginpageobj.logInActions(driver);

            //Home page object initialization
            HomePage homepageobj = new HomePage();
            homepageobj.GoToTimePage(driver);

        }
        [Test, Order(1), Description("This tests create new time record with valid data") ]
        public void CreateTime_test()
        {
            TMP tmpabj = new TMP();
            tmpabj.CreateTimeRecord(driver);

        }
        [Test, Order(2), Description("This tests edit an existing time record with valid data")]
        public void EditTime_test() 
        {
            TMP tmpabj = new TMP();
            tmpabj.EditTimeRecord(driver);
        }
        [Test, Order(3), Description("This tests dele an existing time record")]
        public void DeleteTime_test()
        {
            TMP tmpabj = new TMP();
            tmpabj.DeleteTimeRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
           
    }
}
