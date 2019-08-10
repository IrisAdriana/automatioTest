using FirstTestSolution.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestSolution.Practice.Menu
{
    public class MenuPage:BasePage 

    {
        //IWebDriver webDriver;
        IWebElement contactUsButton => GetDriver().FindElement(By.Id("contact-link"));

        public void ClickContactUs()
        {
            //id = contact-link  --> para redireccionar a una ruta
            //IWebElement contactUsButton = getDriver.FindElement(By.Id("contact-link"));      //by permite seleccionar por Id u otro
            contactUsButton.Click();

            //var menuPage = new MenuPage();
            //ContactUs contactUs = menuPage.ClickContactUs();
            //return contactUs;

            /*ContactUs contactUs = new ContactUs();
            return contactUs;*/
        }
    }
}
