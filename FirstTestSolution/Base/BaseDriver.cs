using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestSolution.Base
{
    public class BaseDriver
    {
        static IWebDriver webDriver;
        public static IWebDriver GetDriver()
        {
            return webDriver;
        }
        public static void SetDriver(IWebDriver driver)
        {
            webDriver = driver;
        }
    }
}
