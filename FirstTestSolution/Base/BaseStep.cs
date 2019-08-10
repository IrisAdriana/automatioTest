using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestSolution.Base
{
    public class BaseStep: BaseDriver
    {
        public void NavigateToInitialSite()
        {
            GetDriver().Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
    }
}
