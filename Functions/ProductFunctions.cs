using Test.Framework.Pages;
using Test.Framework.Util;

namespace Test.Framework.Functions
{
    public class ProductFunctions
    {
        private static ProductsPage ProductsPage = new ProductsPage();

        //Product item 01------------------------------------------
        public static bool isSauceLabsBackpackDisplayed()
        {
            return ProductsPage.SauceLabsBackpackDisplayed();
        }
        public static bool isclickBackpackAddToCart()
        {
            return ProductsPage.clickBackpackAddToCart();
        }
        public static bool isclickBackpackRemove()
        {
            return ProductsPage.clickBackpackRemove();
        }

        //Product item 02------------------------------------------
        public static bool isBikeLightDisplayed()
        {
            return ProductsPage.BikeLightDisplayed();
        }
        public static bool isclickBikeLightAddToCart()
        {

            return ProductsPage.clickBikeLightAddToCart();
        }
        public static bool isclickBikeLightRemove()
        {
            return ProductsPage.clickBikeLightRemove();
        }

        //Product item 03------------------------------------------
        public static bool isBoltTShirtDisplayed()
        {
            return ProductsPage.BoltTShirtDisplayed();
        }
        public static bool isclickBoltTShirtAddToCart()
        {
            return ProductsPage.clickBoltTShirtAddToCart();
        }
        public static bool isclickBoltTShirtRemove()
        {
            return ProductsPage.clickBoltTShirtRemove();
        }

        //Product item 04------------------------------------------
        public static bool isFleeceJacketDisplayed()
        {
            return ProductsPage.FleeceJacketDisplayed();
        }
        public static bool isclickFleeceJacketAddToCart()
        {
            return ProductsPage.clickFleeceJacketAddToCart();
        }
        public static bool isclickFleeceJacketRemove()
        {
            return ProductsPage.clickFleeceJacketRemove();
        }
        public static bool isclickFleeceJacket()
        {
            return ProductsPage.clickFleeceJacket();
        }
        public static bool isProductDescriptionMatches()
        {
            return ProductsPage.ProductDescriptionMatches();
        }
        
        //Product item 05------------------------------------------
        public static bool isOnesieDisplayed()
        {
            return ProductsPage.OnesieDisplayed();
        }
        public static bool isclickOnesieAddToCart()
        {
            return ProductsPage.clickOnesieAddToCart();
        }
        public static bool isclickOnesieRemove()
        {
            return ProductsPage.clickOnesieRemove();
        }

        //Product item 06------------------------------------------
        public static bool isTestallTheThingsTShirtRedDisplayed()
        {
            return ProductsPage.TestallTheThingsTShirtRedDisplayed();
        }
        public static bool isclickTestallTheThingsTShirtRedAddToCart()
        {
            return ProductsPage.clickTestallTheThingsTShirtRedAddToCart();
        }
        public static bool isclickTestallTheThingsTShirtRedRemove()
        {
            return ProductsPage.clickTestallTheThingsTShirtRedRemove();
        }
        //SortContainer
        public static bool isSortContainerDisplayed()
        {
            return ProductsPage.SortContainerDisplayed();
        }
        public static bool isclickSortContainer()
        {
            return ProductsPage.clickSortContainer();
        }
        public static bool isClickDropdown()
        {
            return ProductsPage.ClickDropdown();
        }
    }
}
