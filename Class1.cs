using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using WD_Basics.Pages;

namespace WD_Basics
{
    public class Class1
    {
        private IWebDriver driver;
        Random rnd = new Random();

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void CreateNewUser()
        {
            BasePage home = new BasePage(driver);
            home.goToPage();
            SigninPage signinPage = home.goToSignUpPage();
            string usern = "abcqwerty2";
            LoginPage loginPage = signinPage.EnterData(usern, usern+"@ef.in", "qwerty123");
            loginPage.GoToAccountPage(usern);
        }
        
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }


    }
}
