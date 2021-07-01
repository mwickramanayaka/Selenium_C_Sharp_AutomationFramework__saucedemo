using System;
using OpenQA.Selenium;
using Test.Framework.Util;

namespace Test.Framework.Pages
{
    class YourCartPage : BasePage
    {
        //########## Setup ############
        private static Saucedemo Saucedemo;

        //########### Element Definition #############
        //Shopping cart
        private By ShoppingCart = By.XPath("//*[@id='shopping_cart_container']");
        private By YourCart = By.XPath("//*[@id='header_container']/div[2]/span");
        private By Checkout = By.XPath("//*[text()='Checkout']");
        private By ContinueShopping = By.XPath("//*[@id='continue-shopping']");
        

        //################## Methods ############
        public YourCartPage()
        {
            Saucedemo = new Saucedemo(driver);
        }

        public bool clickShoppingCart()
        {
            Saucedemo.sleep(2);
            return Saucedemo.ClickElement(ShoppingCart);
        }
        public bool YourCartDisplayed()
        {
            return Saucedemo.IsElementVisible(YourCart);
        }
        public bool clickCheckout()
        {
            Saucedemo.sleep(2);
            Saucedemo.WaitForElementVisible(Checkout);
            return Saucedemo.ClickElement(Checkout);
        }
        public bool clickContinueShopping()
        {
            Saucedemo.sleep(2);
            return Saucedemo.ClickElement(ContinueShopping);
        }
        

    }
}
