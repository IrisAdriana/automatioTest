using FirstTestSolution.Base;
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
    public class NavigationSteps:BaseStep
    {

        public ContactUs NavigationToContacUs()
        {
            NavigateToInitialSite();
            MenuPage menuPage = new MenuPage();
            menuPage.ClickContactUs();
            ContactUs contactUs = new ContactUs();
            return contactUs;

        }
    }
}
