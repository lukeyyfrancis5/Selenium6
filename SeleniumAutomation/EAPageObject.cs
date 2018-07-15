using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumAutomation
{
    class EAPageObject
    {
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement TitleID { get; set; }

        [FindsBy(How = How.Name, Using = "Intial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }


        public void FillUserForm(string intial, string firstname, string middlename)
        {

            txtInitial.EnterText(intial);
            txtFirstName.EnterText(firstname);
            txtMiddleName.EnterText(middlename);
            btnSave.Clicks();

            //SeleniumSetMethods.EnterText(txtInitial, intial);
            //SeleniumSetMethods.EnterText(txtFirstName, firstname);
            //SeleniumSetMethods.EnterText(txtMiddleName, middlename);
            //SeleniumSetMethods.Click(btnSave);


            //txtInitial.SendKeys(intial);
            //txtFirstName.SendKeys(firstname);
            //txtMiddleName.SendKeys(middlename);
            //btnSave.Click();    
        }
    }
}
