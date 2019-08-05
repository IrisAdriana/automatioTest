using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestSolution.Practice.Menu
{
    public class MenuPage
    {
        IWebDriver webDriver;

        public MenuPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        public void ClickContactUs()
        {
            //id = contact-link  --> para redireccionar a una ruta
            IWebElement contactUsButton = webDriver.FindElement(By.Id("contact-link"));      //by permite seleccionar por Id u otro
            contactUsButton.Click();
            //ContactUs contactUs = new ContactUs(webDriver);
            //return contactUs;
        }
    }
}
