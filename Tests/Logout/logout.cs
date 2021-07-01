using NUnit.Framework;
using Test.Framework.Util;
using Test.Framework.Functions;

namespace Test.Framework.Tests.Logout
{
    [Category("Logout")]
    [TestFixture]
    class logout : TestBase
    {
        [Test]
        public void TC_TS01_Login_Success_AC1()
        {
            Assert.IsTrue(LogInFunctions.isGotoPage(Settings.LoginUrl));
            Assert.IsTrue(LogInFunctions.isLogInHeadingDisplayed());
            Assert.IsTrue(LogInFunctions.isLogInDisplayed());
            Assert.IsTrue(LogInFunctions.isUserLogIn(Settings.UserName_Correct, Settings.Password_Correct));
            Assert.IsTrue(LogInFunctions.isloginDisplayedproducts());
        }
        [Test]
        public void TC_TS02_Logout_Success_AC2()
        {
            Assert.IsTrue(LogInFunctions.isClickMenuBtn());
            Assert.IsTrue(LogInFunctions.isLogoutBtnDisplayed());
            Assert.IsTrue(LogInFunctions.isClickLogoutBtn());
            Assert.IsTrue(LogInFunctions.isLogInDisplayed());
        }

    }
}
