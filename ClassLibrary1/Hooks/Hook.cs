using FirstTestSolution.initializer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Hooks
{
    public class Hook :Init
    {
        [TestInitialize]
        public void TestSetup()
        {
            OpenBrowser();
        }
        [TestCleanup]
        public void TestCleanUp()
        {
            CloseBrowser();
        }
    }
}
