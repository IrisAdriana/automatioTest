using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestSolution.Practice.ContactUs
{
    public class ContactUs
    {
        IWebDriver webDriver;

        public ContactUs(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        public enum Options
        {
            ByText,
            ByValue,
            ByIndex
        }
        public void SelectHeadingComboBox( Options option, string value)
        {
            // id = id_contact --> id general del comboBox 
            IWebElement subjectHeading = webDriver.FindElement(By.Id("id_contact"));    // en caso de comboBox nos creamos un objeto de tipo selectElement
                                                                                        // enviamos el elemento al costructor del objeto creado
            SelectElement subjectHeadingCBox = new SelectElement(subjectHeading);       // agregamos selenium.Support en el nuget para selectElement
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
            //subjectHeadingCBox.SelectByText("Customer service");
        }
        public void SetEmailAddress(string email)
        {
            // para input:
            IWebElement mailAddressInput = webDriver.FindElement(By.Name("from"));
            mailAddressInput.SendKeys(email);
        }
        public void SetOrderReference(string orderReference)
        {
            IWebElement orderRefenceInput = webDriver.FindElement(By.Name("id_order"));
            orderRefenceInput.SendKeys(orderReference);

        }

        public void SetAttachFile(string filePath)
        {
            //para agregar archivos o documentos
            IWebElement attachFile = webDriver.FindElement(By.Id("fileUpload"));
            attachFile.SendKeys(filePath);

        }
        public void setMessage(string message)
        {
            IWebElement messageInput = webDriver.FindElement(By.Id("message"));
            messageInput.SendKeys(message);
        }
        public void ClickSend()
        {
            IWebElement submitMessage = webDriver.FindElement(By.Id("submitMessage"));
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
            IWebElement confirmationLabel = webDriver.FindElement(By.XPath("//p[@class='alert alert-success']"));
            string message = confirmationLabel.Text;
            return message;
            //string expectedMessage = "Your message has been successfully sent to our team.";
        }
    }
}
