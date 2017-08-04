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
            bool _isRemote = Convert.ToBoolean(ConfigurationManager.AppSettings["Remote"]);
            if (_isRemote)
            {
                coreTest = new SpecFlowCoreTest(browserName, string.Empty, string.Empty, SeleniumCoreSettings.HubUri, SeleniumCoreSettings.ExtrasUri);
                Console.WriteLine("In Remote");
            }
            else {
                coreTest = new SpecFlowCoreTest(browserName);
                Console.WriteLine("In Local");
            }
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
