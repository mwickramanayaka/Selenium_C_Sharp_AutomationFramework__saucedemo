using System;
using NUnit.Framework;
using Test.Framework.Util;
using System.Threading;
using Test.Framework.Functions;

namespace Test.Framework.tests.ProductCartVerify
{
    [Category("CartVerify")]
    [TestFixture]
    class ProductCartVerify : TestBase
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

            //Product item 02 added to the cart
            Assert.IsTrue(ProductFunctions.isBikeLightDisplayed());
            Assert.IsTrue(ProductFunctions.isclickBikeLightAddToCart());

            //Product item 03 added to the cart
            Assert.IsTrue(ProductFunctions.isBoltTShirtDisplayed());
            Assert.IsTrue(ProductFunctions.isclickBoltTShirtAddToCart());

            //Product item 04 added to the cart
            Assert.IsTrue(ProductFunctions.isFleeceJacketDisplayed());
            Assert.IsTrue(ProductFunctions.isclickFleeceJacketAddToCart());

            //Product item 05 added to the cart
            Assert.IsTrue(ProductFunctions.isOnesieDisplayed());
            Assert.IsTrue(ProductFunctions.isclickOnesieAddToCart());

        }
        [Test]
        public void TC_TS03_Checkout_YourCart_AC3()
        {
            //Go to cart
            Assert.IsTrue(ProductPurchaseFunctions.isclickShoppingCart());
            Assert.IsTrue(ProductPurchaseFunctions.isYourCartDisplayed());
           
            //Check items been listed
            Assert.IsTrue(ProductFunctions.isSauceLabsBackpackDisplayed());
            Assert.IsTrue(ProductFunctions.isBikeLightDisplayed());
            Assert.IsTrue(ProductFunctions.isBoltTShirtDisplayed());
            Assert.IsTrue(ProductFunctions.isFleeceJacketDisplayed());
            Assert.IsTrue(ProductFunctions.isOnesieDisplayed());

            //Remove 3rd item 
            Assert.IsTrue(ProductFunctions.isclickBoltTShirtRemove());

            //verify the item is removed
            Assert.IsFalse(ProductFunctions.isBoltTShirtDisplayed());

            //go back to home page
            Assert.IsTrue(ProductPurchaseFunctions.isclickContinueShopping());

            //Product item 03 added to the cart
            Assert.IsTrue(ProductFunctions.isBoltTShirtDisplayed());
            Assert.IsTrue(ProductFunctions.isclickBoltTShirtAddToCart());

            //Go to cart
            Assert.IsTrue(ProductPurchaseFunctions.isclickShoppingCart());
            Assert.IsTrue(ProductPurchaseFunctions.isYourCartDisplayed());

            //verify the item been listed
            Assert.IsTrue(ProductFunctions.isBoltTShirtDisplayed());

            //checkout
            Assert.IsTrue(ProductPurchaseFunctions.isclickCheckout());

        }
        [Test]
        public void TC_TS04_Checkout_Complete_AC4()
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
