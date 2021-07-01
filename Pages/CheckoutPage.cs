using System;
using OpenQA.Selenium;
using Test.Framework.Util;

namespace Test.Framework.Pages
{
    class CheckoutPage : BasePage
    {
        //########## Setup ############
        private static Saucedemo Saucedemo;

        //########### Element Definition #############

        private By CheckoutYourInformation = By.XPath("//*[text()='Checkout: Your Information']");
        private By FirstName = By.XPath("//*[@id='first-name']");
        private By LastName = By.XPath("//*[@id='last-name']");
        private By ZipPostalCode = By.XPath("//*[@id='postal-code']");
        private By Continue = By.XPath("//*[@id='continue']");
        private By CheckoutFailed = By.XPath("//*[text()='Error: Postal Code is required']");
        private By CheckoutOverview = By.XPath("//*[@id='header_container']/div[2]/span");
        private By finishBtn = By.XPath("//*[@id='finish']");
        private By CheckoutComplete = By.XPath("//*[text()='Checkout: Complete!']");
        private By OrderConfirmation = By.XPath("//*[@class='complete-header' and @class='complete-header'] ");
        

        //################## Methods ############
        public CheckoutPage()
        {
            Saucedemo = new Saucedemo(driver);
        }

        public bool CheckoutYourInformationDisplayed()
        {
            return Saucedemo.IsElementVisible(CheckoutYourInformation);
        }
        public void enterFirstName(string fName)
        {
            Saucedemo.ClickElement(FirstName);
            Saucedemo.Textclear(FirstName);
            Saucedemo.ValueSendkeys(FirstName, fName);
        }
        public void enterLastName(string lname)
        {
            Saucedemo.ClickElement(LastName);
            Saucedemo.Textclear(LastName);
            Saucedemo.ValueSendkeys(LastName, lname);
           
        }
        public void enterZipPostalCode(String zcode)
        {
            Saucedemo.ClickElement(ZipPostalCode);
            Saucedemo.Textclear(ZipPostalCode);
            Saucedemo.ValueSendkeys(ZipPostalCode, zcode);
        }
        public bool clickContinueBtn()
        {
            Saucedemo.sleep(2);
            Saucedemo.WaitForElementVisible(Continue);
            return Saucedemo.ClickElement(Continue);
            
        }
        public bool CheckoutFailedisplayed()
        {
            Saucedemo.WaitForElementVisible(CheckoutFailed);
            return Saucedemo.IsElementVisible(CheckoutFailed);
        }
        public bool CheckoutOverviewDisplayed()
        {
            return Saucedemo.IsElementVisible(CheckoutOverview);
        }

        public bool clickFinishBtn()
        {
            Saucedemo.sleep(2);
            Saucedemo.WaitForElementVisible(finishBtn);
            return Saucedemo.ClickElement(finishBtn);
        }
        public bool CheckoutCompleteDisplayed()
        {
            return Saucedemo.IsElementVisible(CheckoutComplete);
        }
        public bool OrderConfirmationDisplayed()
        {
            Saucedemo.sleep(2);
            bool Element = Saucedemo.IsElementVisible(OrderConfirmation);
            Console.WriteLine(Element + " - Order Confirmed");
            return Element;
        }
        
    }
}
