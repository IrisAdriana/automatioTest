using FirstTestSolution.Base;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestSolution.initializer
{
    public class Init: BaseDriver
    {
        public void OpenBrowser()
        {
            string browserType = "chrome";
            switch (browserType)
            {
                case "chrome":
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--start-maximized");
                    chromeOptions.AddArgument("--incognito");
                    //chromeOptions.AddArgument("--headless");
                    SetDriver(new ChromeDriver(@"C:\Users\ASUS\seleniumWebDriver", chromeOptions));

                    break;
                case "firefox":
                    FirefoxOptions firefoxOptions = new FirefoxOptions(); firefoxOptions.AddArgument("");
                    firefoxOptions.AddArgument("--start-maximized");
                    firefoxOptions.AddArgument("--incognito");
                    //serDriver(new FirefoxOptions(@"C:\Users\ASUS\seleniumWebDriver", firefoxOptions));
                    break;
                // ...... add other browsers
            }
            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //tiempo de espera antes de que un control nos de la excepcion de que no encontro el control
            GetDriver().Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);

        }
        public void CloseBrowser()
        {
           
                GetDriver().Close();
                GetDriver().Quit();
            
        }
    }
}
