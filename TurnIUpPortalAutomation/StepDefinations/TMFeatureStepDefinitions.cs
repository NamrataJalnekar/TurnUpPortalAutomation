using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TurnIUpPortalAutomation.Pages;
using TurnIUpPortalAutomation.Uitilities;

namespace TurnIUpPortalAutomation.StepDefinations
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given(@"I logged in to TurnUp portal sucessfully")]
        public void GivenILoggedInToTurnUpPortalSucessfully()
        {
            driver = new ChromeDriver();
            //throw new PendingStepException();
            LogInPage loginpageobj = new LogInPage();
            loginpageobj.logInActions(driver);
        }

        [Given(@"i navigate to TIme and Material Page")]
        public void GivenINavigateToTImeAndMaterialPage()
        {
           // throw new PendingStepException();
           HomePage homepageobj = new HomePage();
            homepageobj.GoToTimePage(driver);
        }

        [When(@"i create new record")]
        public void WhenICreateNewRecord()
        {
            //throw new PendingStepException();
            TMP tmpObj = new TMP();
            tmpObj.CreateTimeRecord(driver,"Auguest1958", "some description", "$25");
        }

        [Then(@"record should be create sucessfully")]
        public void ThenRecordShouldBeCreateSucessfully()
        {
            //throw new PendingStepException();
            TMP tmpObj2 = new TMP();
            string newCode1 = tmpObj2.GetCode(driver);
            Assert.That(newCode1 == "August1998","Actual code and exsiting code do not match");
        }


       

        [When(@"i update '([^']*)' on an existing time record")]
        public void WhenIUpdateOnAnExistingTimeRecord(string p1)
        {
            // throw new PendingStepException();
            TMP tmpObj3 = new TMP();
            tmpObj3.EditTimeRecord(driver, p1);
        }

        [Then(@"record should have an updated '([^']*)'")]
        public void ThenRecordShouldHaveAnUpdated(string p1)
        {
            // throw new PendingStepException();
            TMP tmpObj4 = new TMP();
            string editedCode=tmpObj4.GetCode(driver);
            Assert.That(editedCode == p1, "Update record unsuccesful.");
        }

    }
}
