using OpenQA.Selenium;
using Test.Framework.Util;

namespace Test.Framework.Pages
{
    public class BasePage
    {
        protected static IWebDriver driver = DriverSetup.GetDriverSetupInstance().GetWebDriver();
        private static BasePage instance;
        public IWebDriver Driver
        {
            get
            {
                return driver;
            }

            set
            {
                driver = value;
            }
        }
    } 
}

