/*using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestSolution
    
{
    [TestClass]
    public class Test

    {

        //framework base : c#
        // UI framework: Selenium webdriver
        //unit test: MsTest

        //ctor y doble tab para crear constructor

        IWebDriver webDriver;
        public Class1()
        {
            webDriver = new ChromeDriver(@"C:\Users\ASUS\seleniumWebDriver");      //options es para que pueda iniciar de modo incognito o no
        }
        // una funcion siempre va a retornar un valor
        // un metodo no retorna un valor (void)

        [TestMethod]
        public void MyFirstTest()
        {
            // abrir el browser para el primer test
            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            //id = contact-link  --> para redireccionar a una ruta
            /*IWebElement contactUsButton = webDriver.FindElement(By.Id("contact-link"));      //by permite seleccionar por Id u otro
            contactUsButton.Click();
            // id = id_contact --> id general del comboBox 
            IWebElement subjectHeading = webDriver.FindElement(By.Id("id_contact"));    // en caso de comboBox nos creamos un objeto de tipo selectElement
            // enviamos el elemento al costructor del objeto creado
            SelectElement subjectHeadingCBox = new SelectElement(subjectHeading);       // agregamos selenium.Support en el nuget para selectElement
            // object = Customer service --> escogemos un elemento especifico dentro del comboBox 
            subjectHeadingCBox.SelectByText("Customer service");

            // para input:
            IWebElement mailAddressInput = webDriver.FindElement(By.Name("from"));
            mailAddressInput.SendKeys("lirio1818@gmail.com");

            IWebElement orderRefenceInput = webDriver.FindElement(By.Name("id_order"));
            orderRefenceInput.SendKeys("4561");

            //para agregar archivos o documentos
            IWebElement attachFile = webDriver.FindElement(By.Id("fileUpload"));
            attachFile.SendKeys(@"C:\Users\ASUS\fileTest.txt");

            IWebElement messageInput = webDriver.FindElement(By.Id("message"));
            messageInput.SendKeys("hello");

            IWebElement submitMessage = webDriver.FindElement(By.Id("submitMessage"));
            submitMessage.Click();



            //seccion de codigo que valida si esta funcionando correctamente:
            // --> Your message has been successfully sent to our team
            // xpath para mensajes de alerta --> p[@class='alert alert-success']
            IWebElement confirmationLabel = webDriver.FindElement(By.XPath("//p[@class='alert alert-success']"));
            string actualMessage = confirmationLabel.Text;
            string expectedMessage = "Your message has been successfully sent to our team.";
            Assert.AreEqual(expectedMessage,actualMessage);
        }
        [TestMethod]
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

            IWebElement confirmationLabel = webDriver.FindElement(By.XPath("//div[@class='alert alert-danger']"));
            string actualMessage = confirmationLabel.Text;
            string expectedMessage = "Invalid email address.";
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]
        public void LoginTest()
        {

        }
    }
}
*/