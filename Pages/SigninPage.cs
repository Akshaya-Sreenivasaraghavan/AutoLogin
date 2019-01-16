using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace WD_Basics.Pages
{
    class SigninPage
    {
        private IWebDriver driver;
        
        public SigninPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.TagName, Using = "input")]
        private IWebElement usernameTxt;
        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Email']")]
        private IWebElement emailTxt;
        [FindsBy(How = How.CssSelector, Using = "input[type = 'password']")]
        private IWebElement passwordTxt;
        [FindsBy(How = How.TagName, Using = "button")]
        private IWebElement searchBtn;

        public LoginPage EnterData(string username, string email, string password)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            
            usernameTxt.SendKeys(username);
            emailTxt.SendKeys(email);
            passwordTxt.SendKeys(password);
           driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            searchBtn.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return new LoginPage(driver);
        }
    }
}
