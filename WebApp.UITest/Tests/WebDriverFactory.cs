using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Browser.Core.Framework;
using Browser.Core.Framework.Resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebApp.UITest.StepDefs;

namespace WebApp.UITest.Tests
{
    class WebDriverFactory
    {
        private static IWebDriver Browser;
        private static SpecFlowCoreTest coreTest;

        public static void CreateInstance(string browserName) {
            //string driverPath = SeleniumCoreSettings.DriverLocation;
            //  Browser = new ChromeDriver(driverPath, new BaseChromeOptions(), TimeSpan.FromMinutes(3));
            if ((bool)SeleniumCoreSettings.Remote)
            {
                coreTest = new SpecFlowCoreTest(browserName, string.Empty, string.Empty, SeleniumCoreSettings.HubUri, SeleniumCoreSettings.ExtrasUri);
            }
            else {
                coreTest = new SpecFlowCoreTest(browserName);
            }
            coreTest = new SpecFlowCoreTest(browserName);
            coreTest.TestSetup();
            Browser = coreTest.Browser;
        }

        public static IWebDriver GetDriver() {
            return Browser;
        }

        public static void CloseDriver() {
            coreTest.TearDown();
        }
    }
}
