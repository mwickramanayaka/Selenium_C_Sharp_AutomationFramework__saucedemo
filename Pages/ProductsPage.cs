using System;
using OpenQA.Selenium;
using Test.Framework.Util;

namespace Test.Framework.Pages
{
    public class ProductsPage : BasePage
    {
        //########## Setup ############
        private static Saucedemo Saucedemo;

        //########### Element Definition #############
        //Product item 01
        private By Backpack = By.XPath("//*[text()='Sauce Labs Backpack']");
        private By BackpackAddToCart = By.XPath("//*[@id='add-to-cart-sauce-labs-backpack']");
        private By BackpackRemove = By.XPath("//*[@id='remove-sauce-labs-backpack']");
        //Product item 02
        private By BikeLight = By.XPath("//*[text()='Sauce Labs Bike Light']");
        private By BikeLightAddToCart = By.XPath("//*[@id='add-to-cart-sauce-labs-bike-light']");
        private By BikeLightRemove = By.XPath("//*[@id='remove-sauce-labs-bike-light']");
        //Product item 03
        private By BoltTShirt = By.XPath("//*[text()='Sauce Labs Bolt T-Shirt']");
        private By BoltTShirtAddToCart = By.XPath("//*[@id='add-to-cart-sauce-labs-bolt-t-shirt']");
        private By BoltTShirtRemove = By.XPath("//*[@id='remove-sauce-labs-bolt-t-shirt']");
        //Product item 04
        private By FleeceJacket = By.XPath("//*[text()='Sauce Labs Fleece Jacket']");
        private By FleeceJacketAddToCart = By.XPath("//*[@id='add-to-cart-sauce-labs-fleece-jacket']");
        private By FleeceJacketRemove = By.XPath("//*[@id='remove-sauce-labs-fleece-jacket']");
        private By productDescription = By.XPath("//*[@class='inventory_details_desc large_size']");

        //Product item 05
        private By Onesie = By.XPath(" //*[text()='Sauce Labs Onesie']");
        private By OnesieAddToCart = By.XPath("//*[@id='add-to-cart-sauce-labs-onesie']");
        private By OnesieRemove = By.XPath("//*[@id='remove-sauce-labs-onesie']");
        //Product item 06
        private By TestallTheThingsTShirtRed = By.XPath(" //*[text()='Test.allTheThings() T-Shirt (Red)']");
        private By TestallTheThingsTShirtRedAddToCart = By.XPath("//*[@id='add-to-cart-test.allthethings()-t-shirt-(red)']");
        private By TestallTheThingsTShirtRedRemove = By.XPath("//*[@id='remove-test.allthethings()-t-shirt-(red)']");
       
        //SortContainer
        private By SortContainer = By.XPath("//*[@class='product_sort_container']");
        IWebElement dropDownList = driver.FindElement(By.XPath("//*[@class='product_sort_container']"));

        //################## Methods ############

        public ProductsPage()
        {
            Saucedemo = new Saucedemo(driver);
        }

        //Product item 01------------------------------------------
        public bool SauceLabsBackpackDisplayed()
        {
            Saucedemo.sleep(2);
            return Saucedemo.IsElementVisible(Backpack);
        }
        public bool clickBackpackAddToCart()
        {
            Saucedemo.sleep(1);
            Saucedemo.WaitForElementVisible(BackpackAddToCart);
            return Saucedemo.ClickElement(BackpackAddToCart);
        }
        public bool clickBackpackRemove()
        {
            Saucedemo.WaitForElementVisible(BackpackRemove);
            return Saucedemo.ClickElement(BackpackRemove);
        }

        //Product item 02------------------------------------------
        public bool BikeLightDisplayed()
        {
            Saucedemo.sleep(2);
            return Saucedemo.IsElementVisible(BikeLight);
        }
        public bool clickBikeLightAddToCart()
        {
            Saucedemo.sleep(1);
            Saucedemo.WaitForElementVisible(BikeLightAddToCart);
            return Saucedemo.ClickElement(BikeLightAddToCart);
        }
        public bool clickBikeLightRemove()
        {
            Saucedemo.WaitForElementVisible(BikeLightRemove);
            return Saucedemo.ClickElement(BikeLightRemove);
        }

        //Product item 03------------------------------------------
        public bool BoltTShirtDisplayed()
        {
            Saucedemo.sleep(2);
            return Saucedemo.IsElementVisible(BoltTShirt);
        }
        public bool clickBoltTShirtAddToCart()
        {
            Saucedemo.sleep(1);
            Saucedemo.WaitForElementVisible(BoltTShirtAddToCart);
            return Saucedemo.ClickElement(BoltTShirtAddToCart);
        }
        public bool clickBoltTShirtRemove()
        {
            Saucedemo.WaitForElementVisible(BoltTShirtRemove);
            return Saucedemo.ClickElement(BoltTShirtRemove);
        }

        //Product item 04------------------------------------------
        public bool FleeceJacketDisplayed()
        {
            Saucedemo.sleep(2);
            return Saucedemo.IsElementVisible(FleeceJacket);
        }
        public bool clickFleeceJacketAddToCart()
        {
            Saucedemo.sleep(1);
            Saucedemo.WaitForElementVisible(FleeceJacketAddToCart);
            return Saucedemo.ClickElement(FleeceJacketAddToCart);
        }
        public bool clickFleeceJacketRemove()
        {
            Saucedemo.WaitForElementVisible(FleeceJacketRemove);
            return Saucedemo.ClickElement(FleeceJacketRemove);
        }
        public bool clickFleeceJacket()
        {
            Saucedemo.sleep(2);
            return Saucedemo.ClickElement(FleeceJacket);           
        }
        public bool ProductDescriptionMatches()
        {
            Saucedemo.sleep(2);
            return Saucedemo.VerifyText(productDescription);

        }
        

        //Product item 05------------------------------------------
        public bool OnesieDisplayed()
        {
            Saucedemo.sleep(2);
            return Saucedemo.IsElementVisible(Onesie);
        }
        public bool clickOnesieAddToCart()
        {
            Saucedemo.sleep(1);
            Saucedemo.WaitForElementVisible(OnesieAddToCart);
            return Saucedemo.ClickElement(OnesieAddToCart);
        }
        public bool clickOnesieRemove()
        {
            Saucedemo.WaitForElementVisible(OnesieRemove);
            return Saucedemo.ClickElement(OnesieRemove);
        }

        //Product item 06------------------------------------------
        public bool TestallTheThingsTShirtRedDisplayed()
        {
            Saucedemo.sleep(2);
            return Saucedemo.IsElementVisible(TestallTheThingsTShirtRed);
        }
        public bool clickTestallTheThingsTShirtRedAddToCart()
        {
            Saucedemo.sleep(1);
            Saucedemo.WaitForElementVisible(TestallTheThingsTShirtRedAddToCart);
            return Saucedemo.ClickElement(TestallTheThingsTShirtRedAddToCart);
        }
        public bool clickTestallTheThingsTShirtRedRemove()
        {
            Saucedemo.WaitForElementVisible(TestallTheThingsTShirtRedRemove);
            return Saucedemo.ClickElement(TestallTheThingsTShirtRedRemove);
        }
        //DropDown List
        public bool SortContainerDisplayed()
        {
            return Saucedemo.IsElementVisible(SortContainer);
        }
        public bool clickSortContainer()
        {
            Saucedemo.sleep(2);
            return Saucedemo.IsElementVisible(SortContainer);
        }

        public bool ClickDropdown()
        {
            Saucedemo.sleep(2);
            return Saucedemo.SelectDropDown(dropDownList);
        }
    }
}
