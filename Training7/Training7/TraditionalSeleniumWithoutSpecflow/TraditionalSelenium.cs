using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Training7.TraditionalSeleniumWithoutSpecflow
{
    [TestClass]
    public class TraditionalSelenium
    {
        [TestMethod]
        public void MedicalDeclaration()
        {
            //1.create Instance of the Browser
            IWebDriver Driver;

            //1b.Open the browser
            Driver = new ChromeDriver();

            //1c.Do your test

            //2. Navigate to website
            Driver.Navigate().GoToUrl("https://alpha.protectif.co.uk");

            //2a i.Maximise the window
            Driver.Manage().Window.Maximize();

            //2b.click on Next Button

            Driver.FindElement(By.Id("next-button")).Click();

            //Driver.FindElement(By.XPath("//*[@id='next - button']")).Click();

            Driver.FindElement(By.XPath("//button[@id='retrieve-quote']")).Click();
            //"//input[@type='text' and @placeholder='Username']")]
            Driver.FindElement(By.ClassName("//input[@class='form-control ng-pristine ng-empty ng-invalid ng-invalid-required ng-valid-minlength ng-valid-maxlength ng-touched']")).SendKeys("12345678");


            //2c.Inspect your element

            //2d.Decide on the attribute to use to find your element

            //2e. Copy the attribute

            //2e i. Write the code to find the element


            //2e ii. perform the action( i.e type into the text box)


            //3a Select from a droplist


            //3b. click a submit button


            //3. close Browser
            Driver.Close();


            //2e. click a radio button
        }
    }
}
