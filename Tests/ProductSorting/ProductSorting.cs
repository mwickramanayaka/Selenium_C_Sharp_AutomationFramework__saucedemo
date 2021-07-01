using System;
using NUnit.Framework;
using Test.Framework.Util;
using Test.Framework.Functions;

namespace Test.Framework.tests.ProductSorting
{
    [Category("ProductSorting")]
    [TestFixture]
    class ProductSorting : TestBase
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
        public void TC_TS02_Sorting_AC2()
        {
            //click SortContainer
            Assert.IsTrue(ProductFunctions.isSortContainerDisplayed());
            Assert.IsTrue(ProductFunctions.isclickSortContainer());

            //Sort the items from price low to high order
            Assert.IsTrue(ProductFunctions.isClickDropdown());            
        }
        [Test]
        public void TC_TS03_Product_Description_Validatiion_AC3()
        {
            //Fleece Jacket product description validation
            Assert.IsTrue(ProductFunctions.isFleeceJacketDisplayed());
            Assert.IsTrue(ProductFunctions.isclickFleeceJacket());
            Assert.IsTrue(ProductFunctions.isProductDescriptionMatches());
        }
    }
}
