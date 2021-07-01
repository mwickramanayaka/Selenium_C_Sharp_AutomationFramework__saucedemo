using System;
using OpenQA.Selenium;
using Test.Framework.Util;

namespace Test.Framework.Pages
{
    public class LogInPage : BasePage
    {
        //########## Setup ############
        private static Saucedemo Saucedemo;
    
        //########### Element Definition #############
        private By loginHeading = By.XPath("//*[@id='root']/div/div[1]");
        private By userName = By.XPath("//*[@id='user-name']");
        private By password = By.XPath("//*[@id='password']");
        private By btnLogIn = By.XPath("//*[@id='login-button']");
        private By loginfailed = By.XPath("//*[@id='login_button_container']/div/form/div[3]");
        private By productsMenu = By.XPath("//*[@id='header_container']/div[2]/span");
        //logout
        private By btnmenu = By.XPath("//*[@id='react-burger-menu-btn']");
        private By btnlogout = By.XPath("//*[@id='logout_sidebar_link']");

        //################## Methods ############
        public LogInPage()
        {
            Saucedemo = new Saucedemo(driver);
        }

        public bool logInHeadingDisplayed()
        {
            Saucedemo.WaitForElementVisible(loginHeading);
            return Saucedemo.IsElementVisible(loginHeading);
        }

        public bool LogInDisplayed()
        {
            Saucedemo.sleep(2);
            return Saucedemo.IsElementVisible(btnLogIn);
        }

        public void enterUserName(string uName)
        {
            Saucedemo.ClickElement(userName);
            Saucedemo.Textclear(userName);
            Saucedemo.ValueSendkeys(userName, uName);
        }
        public void enterPassword(string pwd)
        {
            Saucedemo.ClickElement(password);
            Saucedemo.Textclear(password);
            Saucedemo.ValueSendkeys(password, pwd);
        }
        public bool clicklogInBtn()
        {
            Saucedemo.WaitForElementVisible(btnLogIn);
            return Saucedemo.ClickElement(btnLogIn);
        }
        public bool loginFaildMSGdisplayed()
        {
            Saucedemo.WaitForElementVisible(loginfailed);
            return Saucedemo.IsElementVisible(loginfailed);
        }
        public bool loginDisplayedproducts()
        {
            Saucedemo.sleep(2);
            return Saucedemo.IsElementVisible(productsMenu);
        }
        public bool gotoPage(string url)
        {
            return Saucedemo.navigateTo(url);
        }
        public bool ClickMenuBtn()
        {
            Saucedemo.WaitForElementVisible(btnmenu);
            return Saucedemo.ClickElement(btnmenu);
        }
        public bool LogoutBtnDisplayed()
        {
            Saucedemo.WaitForElementVisible(btnlogout);
            return Saucedemo.IsElementVisible(btnlogout);
        }
        public bool ClickLogoutBtn()
        {
            Saucedemo.sleep(2);
            return Saucedemo.ClickElement(btnlogout);
        }
        

    }
}
