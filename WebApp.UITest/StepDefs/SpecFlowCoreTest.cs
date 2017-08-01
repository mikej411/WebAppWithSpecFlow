using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Browser.Core.Framework;
using WebApp.AppFramework;

namespace WebApp.UITest.StepDefs
{
    class SpecFlowCoreTest : EATestBase
    {
        public SpecFlowCoreTest(string browserName) : base(browserName)
        {
        }

        public SpecFlowCoreTest(string browserName, string version, string platform, string hubUri, string extrasUri) : base(browserName, version, platform, hubUri, extrasUri)
        {
        }
    }
}
