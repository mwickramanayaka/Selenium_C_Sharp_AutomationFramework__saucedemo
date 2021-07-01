using NUnit.Framework;
using Test.Framework.Util;
using Test.Framework.Functions;

namespace Test.Framework.tests.Login
{
    [Category("Login")]
    [TestFixture]
    class TS_Login_rdm : TestBase
    {
        [Test]
        public void TC_TS01_Login_loaded_AC1()
        {
            Assert.IsTrue(LogInFunctions.isGotoPage(Settings.LoginUrl));
            Assert.IsTrue(LogInFunctions.isLogInHeadingDisplayed());
            Assert.IsTrue(LogInFunctions.isLogInDisplayed());           
        }
        
       [Test]
       public void TC_TS02_Login_wrong_username_AC2()
       {
           Assert.IsTrue(LogInFunctions.isGotoPage(Settings.LoginUrl));
           Assert.IsTrue(LogInFunctions.isLogInHeadingDisplayed());
           Assert.IsTrue(LogInFunctions.isLogInDisplayed());
           Assert.IsTrue(LogInFunctions.isUserLogIn(Settings.UserName_wrong, Settings.Password_Correct));
           Assert.IsTrue(LogInFunctions.isLoginFaildMSGdisplayed());
       }
       [Test]
       public void TC_TS03_Login_wrong_password_AC3()
       {
           Assert.IsTrue(LogInFunctions.isGotoPage(Settings.LoginUrl));
           Assert.IsTrue(LogInFunctions.isLogInHeadingDisplayed());
           Assert.IsTrue(LogInFunctions.isLogInDisplayed());
           Assert.IsTrue(LogInFunctions.isUserLogIn(Settings.UserName_Correct, Settings.Password_wrong));
           Assert.IsTrue(LogInFunctions.isLoginFaildMSGdisplayed());
       }
       [Test]
       public void TC_TS04_Login_Success_AC4()
       {
           Assert.IsTrue(LogInFunctions.isGotoPage(Settings.LoginUrl));
           Assert.IsTrue(LogInFunctions.isLogInHeadingDisplayed());
           Assert.IsTrue(LogInFunctions.isLogInDisplayed());
           Assert.IsTrue(LogInFunctions.isUserLogIn(Settings.UserName_Correct, Settings.Password_Correct));
           Assert.IsTrue(LogInFunctions.isloginDisplayedproducts());
       } 
    }
}
