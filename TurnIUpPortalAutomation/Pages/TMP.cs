using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TurnIUpPortalAutomation.Pages
{
    public class TMP
    {
        //navigate to material module 
        public void CreateTimeRecord(IWebDriver driver)
        {
            //create new record in time and material
            IWebElement createNewOption = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewOption.Click();

            //select time record from drop down
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement findTimeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            findTimeCode.Click();



            //enter code

            IWebElement codeInput = driver.FindElement(By.Id("Code"));
            codeInput.SendKeys("August1998");


            //enter description
            IWebElement descriptionInput = driver.FindElement(By.Id("Description"));
            descriptionInput.SendKeys("August2025");

            //enter descriptipn
            IWebElement priceInput = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceInput.SendKeys("$12");


            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);
            //check new time record has been created succesfully 
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(newCode.Text == "August1998", "This record not created");
            //if (newCode.Text == "August1998")
            //{
            //    Assert.Pass("New record created");
            //}
            //else
            //{
            //    Assert.Pass("New record has not been created");
            //}

        }
        public void EditTimeRecord(IWebDriver driver)
        {
        }
        public void DeleteTimeRecord(IWebDriver driver)
        { }

    }
}
