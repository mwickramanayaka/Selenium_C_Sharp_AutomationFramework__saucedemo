using System;
using NUnit.Framework;
using Test.Framework.Util;
using Test.Framework.Functions;

namespace Test.Framework.tests.ProductPurchase
{
    [Category("Purchase")]
    [TestFixture]
    class TS_ProductPurchase : TestBase
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
        public void TC_TS02_Add_To_Cart_AC2()
        {
            //Product item 01 added to the cart
            Assert.IsTrue(ProductFunctions.isSauceLabsBackpackDisplayed());
            Assert.IsTrue(ProductFunctions.isclickBackpackAddToCart());

            //Product item 04 added to the cart
            Assert.IsTrue(ProductFunctions.isFleeceJacketDisplayed());
            Assert.IsTrue(ProductFunctions.isclickFleeceJacketAddToCart());

            //Product item 06 added to the cart
            Assert.IsTrue(ProductFunctions.isTestallTheThingsTShirtRedDisplayed());
            Assert.IsTrue(ProductFunctions.isclickTestallTheThingsTShirtRedAddToCart());

        }
        [Test]
        public void TC_TS03_Checkout_YourCart_AC3()
        {
            //Go to cart
            Assert.IsTrue(ProductPurchaseFunctions.isclickShoppingCart());
            Assert.IsTrue(ProductPurchaseFunctions.isYourCartDisplayed());
            //Check items been listed
            Assert.IsTrue(ProductFunctions.isSauceLabsBackpackDisplayed());
            Assert.IsTrue(ProductFunctions.isFleeceJacketDisplayed());
            Assert.IsTrue(ProductFunctions.isTestallTheThingsTShirtRedDisplayed());
            //checkout
            Assert.IsTrue(ProductPurchaseFunctions.isclickCheckout());
          
        }
        [Test]
        public void TC_TS04_Purchase_Complete_AC4()
        {
            //Checkout_Your_Info
            Assert.IsTrue(ProductPurchaseFunctions.isCheckoutYourInformationDisplayed());
            Assert.IsTrue(ProductPurchaseFunctions.isCheckoutYourInfo(Settings.FirstName, Settings.LastName, Settings.ZipPostalCode));
           
            //Checkout_Overview
            Assert.IsTrue(ProductPurchaseFunctions.isCheckoutOverviewDisplayed());
            Assert.IsTrue(ProductPurchaseFunctions.isclickFinishBtn());
            
            //Checkout_Complete
            Assert.IsTrue(ProductPurchaseFunctions.isCheckoutCompleteDisplayed());
            Assert.IsTrue(ProductPurchaseFunctions.isOrderConfirmationDisplayed());
        }


    }
}
