using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Intialize()
        {
            // Create the reference for Browser
            PropertiesCollection.driver = new ChromeDriver();

            // Navigate to Google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Open URL");
        }


        [Test]
        public void ExecuteTest()
        {
            ExcelLib.PopulateInCollection(@"D:\Data.xlsx");
            // Log into application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));

            pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"));


            //// Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            ////Intial
            //SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            //Console.WriteLine("The value from my Title is: ", SeleniumGetMethods.GetText("TitleId", PropertyType.Id));
            //Console.WriteLine("The value from my Initial is:", SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //// Click
            //SeleniumSetMethods.Click("Save", PropertyType.Name);
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Method");
        }

        [TearDown]
        public void Cleanup()
        {
            // Quit
            PropertiesCollection.driver.Close();
            Console.WriteLine("Close Browser");

        }
    }
}
