using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestSolution.Base
{
    public class BasePage:BaseDriver
    {
        public static WebDriverWait wait;
        public static Actions actions;
        public BasePage()
        {
            wait = new WebDriverWait(GetDriver(),TimeSpan.FromSeconds(10));
            actions = new Actions(GetDriver());
        }
        public enum Options
        {
            ByText,
            ByValue,
            ByIndex
        }
        public void SelectComboBox(IWebElement element, Options option, string value)
        {
            SelectElement subjectHeadingCBox = new SelectElement(element);       // agregamos selenium.Support en el nuget para selectElement
                                                                                        // object = Customer service --> escogemos un elemento especifico dentro del comboBox 

            switch (option)
            {
                case Options.ByText:
                    subjectHeadingCBox.SelectByText(value);
                    break;
                case Options.ByValue:
                    subjectHeadingCBox.SelectByValue(value);
                    break;
                case Options.ByIndex:
                    subjectHeadingCBox.SelectByIndex(int.Parse(value));
                    break;
            }
        }
    }
}
