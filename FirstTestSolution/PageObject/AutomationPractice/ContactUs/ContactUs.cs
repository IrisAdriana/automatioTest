using FirstTestSolution.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestSolution.Practice.ContactUs
{
    public class ContactUs:BasePage
    {
        //WebDriver webDriver;
        //[FindsBy(How = How.Id, Using = "id_contact")]    //antiguamente
        //IWebElement subjectHeading;


        IWebElement subjectHeading => GetDriver().FindElement(By.Id("id_contact"));
        IWebElement mailAddressInput => GetDriver().FindElement(By.Name("from"));
        IWebElement orderRefenceInput => GetDriver().FindElement(By.Name("id_order"));
        //para agregar archivos o documentos
        IWebElement attachFile => GetDriver().FindElement(By.Id("fileUpload"));
        IWebElement messageInput => GetDriver().FindElement(By.Id("message"));
        IWebElement submitMessage => GetDriver().FindElement(By.Id("submitMessage"));
        IWebElement confirmationLabel =>GetDriver().FindElement(By.XPath("//p[@class='alert alert-success']"));



        //[FindsBy(How = How.Name, Using = "from")]
        //IWebElement emailInput;


        
        /// <summary>
        /// description SelectHeadingComboBox method
        /// </summary>
        /// <param name="option">parametrer 1 description</param>
        /// <param name="value">parametrer 2 description</param>
        public void SelectHeadingComboBox( Options option, string value)
        {
            // id = id_contact --> id general del comboBox 
            //IWebElement subjectHeading = webDriver.FindElement(By.Id("id_contact"));    // en caso de comboBox nos creamos un objeto de tipo selectElement
                                                                                        // enviamos el elemento al costructor del objeto creado
           
            SelectComboBox(subjectHeading,option,value);
            //subjectHeadingCBox.SelectByText("Customer service");
        }
        public void SetEmailAddress(string email)
        {
            // para input:
            mailAddressInput.SendKeys(email);
        }
        public void SetOrderReference(string orderReference)
        {
            orderRefenceInput.SendKeys(orderReference);
        }

        public void SetAttachFile(string filePath)
        {
            //para agregar archivos o documentos
            attachFile.SendKeys(filePath);
        }
        public void setMessage(string message)
        {
            messageInput.SendKeys(message);
        }
        public void ClickSend()
        {
            submitMessage.Click();
        }
        public void FillContactUsForm(Options option, string value, string email, string orderRefence, string filePath, string message)
        {
            SelectHeadingComboBox(option, value);
            SetEmailAddress(email);
            SetOrderReference(orderRefence);
            SetAttachFile(filePath);
            setMessage(message);
            ClickSend();

        }
        public string GetConfirmationMessage()
        {
            
            return confirmationLabel.Text;
            //string expectedMessage = "Your message has been successfully sent to our team.";
        }
    }
}
