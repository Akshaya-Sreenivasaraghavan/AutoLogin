using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace WD_Basics.Pages
{
    class BasePage
    {
        public IWebDriver driver = null;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

       // [FindsBy(How = How.CssSelector, Using = "href = '/register'")]
        [FindsBy(How = How.LinkText, Using = "Sign up")]
        // [FindsBy(How =How.CssSelector, Using = "a[class = 'nav-link'])")]
        private IWebElement signup;

        //signup = drivehref="/register"

        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://angular.realworld.io/");
        }

        public SigninPage goToSignUpPage()
        {
            signup.Click();
            return new SigninPage(driver);
        }

    }
}
