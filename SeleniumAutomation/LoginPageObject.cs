using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace SeleniumAutomation
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "Username")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }


        public EAPageObject Login(string userName, string password)
        {
            // UserName
            txtUserName.EnterText(userName);
            // Password
            txtPassword.EnterText(password);
            // Click button
            btnLogin.Clicks();
            // Return the page object
            return new EAPageObject();
        }
    }
}
