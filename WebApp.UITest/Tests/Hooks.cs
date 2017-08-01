using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Browser.Core.Framework;
using TechTalk.SpecFlow;

namespace WebApp.UITest.Tests
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            WebDriverFactory.CreateInstance(BrowserNames.Chrome);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            WebDriverFactory.CloseDriver();
        }
    }
}
