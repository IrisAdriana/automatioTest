using ClassLibrary1.Hooks;
using FirstTestSolution.Practice.ContactUs;
using FirstTestSolution.Practice.Menu;
using FirstTestSolution.Steps.AutomationPractice.Navigation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstTestSolution
    
{
    [TestClass]
    public class Class1: Hook
    {

        //framework base : c#
        // UI framework: Selenium webdriver
        //unit test: MsTest

        //ctor y doble tab para crear constructor

        
        NavigationSteps navigationSteps; 
        

        [TestMethod, TestCategory("ContactUs")]
        public void ContactFormIsSentCorrectly()
        {
            
            ContactUs contactUs = navigationSteps.NavigationToContacUs();
            //explicit waiter(no recomendable)
            Thread.Sleep(TimeSpan.FromSeconds(10));     //va a esperar 10 segundos y luego continuar con el test 

            //explicit waiters with expected conditions(install selenium extras)


            contactUs.FillContactUsForm(ContactUs.Options.ByText,"Customer service","iris@gmail.com","45612", @"C:\Users\ASUS\fileTest.txt", "Hello");
            string actualMessage = contactUs.GetConfirmationMessage();
            string expectedMessage = "Your message has been successfully sent to our team.";

            Assert.AreEqual(expectedMessage,actualMessage);
        }

        [TestInitialize]
        public void Setup()
        {
            /*ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");       //pantalla maximizada
            options.AddArgument("--incognito");
            options.AddArgument("--headless");      //no visualiza la pagina, realiza el proceso por debajo
            
            webDriver = new ChromeDriver(@"C:\Users\ASUS\seleniumWebDriver",options);      //options es para que pueda iniciar de modo incognito o no
            
            //implicid waiters
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //tiempo de espera antes de que un control nos de la excepcion de que no encontro el control
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120); //tiempo de espera antes de que no encuentre la pagina
            */
            navigationSteps = new NavigationSteps();
            //webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        /*[TestCleanup]
        public void TearDown()
        {
            webDriver.Close();
            webDriver.Quit();
        }
        */
        
        //[TestMethod,TestCategory("Contact Invalid Data")]
        //public void ContactFormIsNotSentWithInvalidData()
        //{

        //}
        /* [TestMethod]
         public void MySecondTest()
         {
             webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php");
             //id = contact-link  --> para redireccionar a una ruta
             IWebElement contactUsButton = webDriver.FindElement(By.Id("contact-link"));     
             contactUsButton.Click();
             // id = id_contact --> id general del comboBox 
             IWebElement subjectHeading = webDriver.FindElement(By.Id("id_contact"));    
             SelectElement subjectHeadingCBox = new SelectElement(subjectHeading);       
             subjectHeadingCBox.SelectByText("Customer service");

             // para input:
             IWebElement mailAddressInput = webDriver.FindElement(By.Name("from"));
             mailAddressInput.SendKeys("1456256");

             IWebElement submitMessage = webDriver.FindElement(By.Id("submitMessage"));
             submitMessage.Click();


             //seccion de codigo que valida si esta funcionando correctamente:
             // --> Your message has been successfully sent to our team
             // xpath para mensajes de alerta --> p[@class='alert alert-success']


             IWebElement confirmationLabel = webDriver.FindElement(By.XPath("//div[@class='alert alert-danger']"));
             string actualMessage = confirmationLabel.Text;
             string expectedMessage = "Invalid email address.";
             Assert.AreEqual(expectedMessage, actualMessage);
         }*/


    }
}
