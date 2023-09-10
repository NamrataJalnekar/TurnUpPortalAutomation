using NUnit.Framework;
using OpenQA.Selenium.Chrome;
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

    public class EmployeeTest : CommonDriver
    {
        [SetUp]
        public void EmployeeSetUp() 
        {
            driver = new ChromeDriver();
            //login Page intialization
            LogInPage loginpageobj = new LogInPage();
            loginpageobj.logInActions(driver);

            //Home page object initialization
            HomePage homepageobj = new HomePage();
            homepageobj.GoToTimePage(driver);
        }

        [Test]
        public void CreateEmployee_Test()
        {
            EmployeesPage employeePageObj = new EmployeesPage();
            employeePageObj.CreateEmployee(driver);
        }

        [Test]
        public void EditEmployee_Test()
        {
            EmployeesPage employeePageObj = new EmployeesPage();
            employeePageObj.EditEmployee(driver);
        }

        [Test]
        public void DeleteEmployee_Test()
        {
            EmployeesPage employeePageObj = new EmployeesPage();
            employeePageObj.DeleteEmployee(driver);
        }


        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }
    }
}
