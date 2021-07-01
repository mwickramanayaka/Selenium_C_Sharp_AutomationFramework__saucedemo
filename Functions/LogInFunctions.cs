using System;
using Test.Framework.Pages;

namespace Test.Framework.Functions
{
    public class LogInFunctions
    {
        private static LogInPage LogInPage = new LogInPage();

        public static bool isGotoPage(string url)
        {
            return LogInPage.gotoPage(url);
        }

        public static bool isLogInHeadingDisplayed()
        {
            return LogInPage.logInHeadingDisplayed();
        }

        public static bool  isLogInDisplayed()
        {
            return LogInPage.LogInDisplayed();
        }
        public static bool isClickLogInBtn()
        {
            return LogInPage.clicklogInBtn();
        }

        public static bool isUserLogIn(string uname, string pwd)
        {
            LogInPage.enterUserName(uname);
            LogInPage.enterPassword(pwd);
            return LogInPage.clicklogInBtn();
        }
        public static bool isLoginFaildMSGdisplayed()
        {
            return LogInPage.loginFaildMSGdisplayed();
        }

        public static bool isloginDisplayedproducts()
        {
            return LogInPage.loginDisplayedproducts();
        }
        public static bool isClickMenuBtn()
        {
            return LogInPage.ClickMenuBtn();
        }
        public static bool isLogoutBtnDisplayed()
        {
            return LogInPage.LogoutBtnDisplayed();
        }
        public static bool isClickLogoutBtn()
        {
            return LogInPage.ClickLogoutBtn();
        }
    }
}
