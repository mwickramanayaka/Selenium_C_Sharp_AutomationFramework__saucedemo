using Test.Framework.Pages;

namespace Test.Framework.Functions
{
    public class ProductPurchaseFunctions
    {
        private static YourCartPage YourCartPage = new YourCartPage();
        private static CheckoutPage CheckoutPage = new CheckoutPage();

        public static bool isclickShoppingCart()
        {
            return YourCartPage.clickShoppingCart();
        }
        public static bool isYourCartDisplayed()
        {
            return YourCartPage.YourCartDisplayed();
        }
        public static bool isclickCheckout()
        {
            return YourCartPage.clickCheckout();
        }
        public static bool isCheckoutYourInformationDisplayed()
        {
            return CheckoutPage.CheckoutYourInformationDisplayed();
        }
        public static bool isCheckoutYourInfo(string fname, string lname, string zcode)
        {
            CheckoutPage.enterFirstName(fname);
            CheckoutPage.enterLastName(lname);
            CheckoutPage.enterZipPostalCode(zcode);
            return CheckoutPage.clickContinueBtn();
        }
        public static bool isCheckoutFailed()
        {
            return CheckoutPage.CheckoutOverviewDisplayed();
        }
        public static bool isCheckoutOverviewDisplayed()
        {
            return CheckoutPage.CheckoutOverviewDisplayed();
        }
        
        public static bool isclickFinishBtn()
        {
            return CheckoutPage.clickFinishBtn();
        }
        public static bool isCheckoutCompleteDisplayed()
        {
            return CheckoutPage.CheckoutCompleteDisplayed();
        }
        public static bool isOrderConfirmationDisplayed()
        {
            return CheckoutPage.OrderConfirmationDisplayed();
        }
        public static bool isclickContinueShopping()
        {
            return YourCartPage.clickContinueShopping();
        }
    }
}
