using FirstTestSolution.Practice.ContactUs;
using FirstTestSolution.Practice.Menu;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestSolution.Steps.AutomationPractice.Navigation
{
    public class NavigationSteps
    {
        IWebDriver webDriver;

        public NavigationSteps(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public ContactUs NavigationToContacUs()
        {
            MenuPage menuPage = new MenuPage(webDriver);
            menuPage.ClickContactUs();
            ContactUs contactUs = new ContactUs(webDriver);
            return contactUs;

        }
    }
}
