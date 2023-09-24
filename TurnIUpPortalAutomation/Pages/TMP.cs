using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TurnIUpPortalAutomation.Uitilities;
using System.Diagnostics;

namespace TurnIUpPortalAutomation.Pages
{
    public class TMP
    {
        //navigate to material module 
        public void CreateTimeRecord(IWebDriver driver , string code, string description, string price)
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
            codeInput.SendKeys(code);


            //enter description
            IWebElement descriptionInput = driver.FindElement(By.Id("Description"));
            descriptionInput.SendKeys(description);

            //enter descriptipn
            IWebElement priceInput = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceInput.SendKeys(price);


            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);
            //check new time record has been created succesfully 
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

          
           // Assert.That(newCode.Text == "August1998", "This record not created");
            //if (newCode.Text == "August1998")
            //{
            //    Assert.Pass("New record created");
            //}
            //else
            //{
            //    Assert.Pass("New record has not been created");
            //}

        }

        public string GetCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;

        }
        public void EditTimeRecord(IWebDriver driver, string code)
        {
            //click the last page arrow button
            IWebElement editGoToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[2]"));
            editGoToLastPage.Click();

            //click on edit button
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[4]/td[5]/a[1]"));
            editButton.Click();

            ////select time record from drop down
            //IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            //typeCodeDropdown.Click();

            //IWebElement findTimeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
            //findTimeCode.Click();



            //enter code

           
            //codeUpdatedInput.SendKeys(code);

            //


            ////enter description
            //IWebElement descriptionInput = driver.FindElement(By.Id("Description"));
            //descriptionInput.SendKeys(description);

            ////enter descriptipn
            //IWebElement priceInput = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            //priceInput.SendKeys(price);


            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

        }

        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement codeUpdatedInput = driver.FindElement(By.Id("Code"));
            return codeUpdatedInput.Text;

        }
        public void DeleteTimeRecord(IWebDriver driver)
        { }

    }
}
