using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WD_Basics.Pages
{
    class LoginPage
    {
        private IWebDriver driver;
        
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            // wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = ".//ul[@class='nav navbar-nav pull-xs-right']/li[4]/a" )]
        private IWebElement profile;
       

        public void GoToAccountPage(string username)
        {
            profile.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
           
        
    }
}

    

