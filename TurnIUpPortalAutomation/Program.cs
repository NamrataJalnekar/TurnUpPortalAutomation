

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Open the browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//launch turn up portal and navigate to login
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//identify username textbox and enter valid username
IWebElement userNameTextbox= driver.FindElement(By.Id("UserName"));
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

//create new record in time and material

//navigate to material module 
IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropdown.Click();
IWebElement timeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeOption.Click();

// click creatre new record
IWebElement createNewOption = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewOption.Click();

//select time record from drop down
IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
typeCodeDropdown.Click();

IWebElement findTimeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
findTimeCode.Click();



//enter code

IWebElement codeInput = driver.FindElement(By.Id("Code"));
codeInput.SendKeys("August2025");


//enter description
IWebElement descriptionInput = driver.FindElement(By.Id("Description"));
descriptionInput.SendKeys("August2025");

//enter descriptipn
IWebElement priceInput = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceInput.SendKeys("$12");


//click on save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(5000);
//check new time record has been created succesfully 
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if(newCode.Text =="August2025")
{
    Console.WriteLine("New record created");
}
else
{
    Console.WriteLine("New record has not been created");
}


