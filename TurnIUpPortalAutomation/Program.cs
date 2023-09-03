

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnIUpPortalAutomation.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        //Open the browser
        IWebDriver driver = new ChromeDriver();
      
        //login Page intialization
        LogInPage loginpageobj = new LogInPage();
        loginpageobj.logInActions(driver);

        //Home page object initialization
        HomePage homepageobj = new HomePage();
        homepageobj.GoToTimePage(driver);

        //TM page object initialization
        TMP tmpabj = new TMP();
        tmpabj.CreateTimeRecord(driver);

        tmpabj.EditTimeRecord(driver);
        tmpabj.DeleteTimeRecord(driver);

      

        

        
       

        
       
    }
}