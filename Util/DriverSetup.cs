using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test.Framework.Util
{
    class DriverSetup
    {

        private IWebDriver webDriver;
        private static DriverSetup singletonInsance;

        public static DriverSetup GetDriverSetupInstance()
        {

            if(singletonInsance == null)
            {
                singletonInsance = new DriverSetup();
            }
            return singletonInsance;
        }

        public void StartDriver()
        {
            webDriver = new ChromeDriver();
        }

        public void QuitDriver()
        {
            webDriver.Close();
            webDriver.Quit();
            
        }

        public IWebDriver GetWebDriver()
        {
            return webDriver;
        }

    }
}
