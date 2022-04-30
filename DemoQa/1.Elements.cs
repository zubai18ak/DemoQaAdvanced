using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace DemoQa
{
    public partial class Elements
    {
        public void TextBox(IWebDriver Driver, IJavaScriptExecutor js)
        {
            Console.Write("Test Case Started: ");
            string name = "Zubair Ahmed";
            string email = "abc@gmail.com";
            string Cadd = "Kolkata";
            string Padd = "Kolkata";

            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//h5[text()='Elements']")).Click();
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Text Box']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("userName")).SendKeys(name);
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("userEmail")).SendKeys(email);
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("currentAddress")).SendKeys(Cadd);
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("permanentAddress")).SendKeys(Padd);
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,500)");


            Thread.Sleep(2000);
            IWebElement ButtonElement = Driver.FindElement(By.Id("submit"));
            Thread.Sleep(2000);
            ButtonElement.Click();
            Task.Delay(3000).Wait();

            Console.WriteLine("Testing Close");
            Driver.Close();
            Driver.Quit();
        }

        public void CheckBox(IWebDriver Driver,IJavaScriptExecutor js)
        {
            Thread.Sleep(200);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Check Box']")).Click();
            Thread.Sleep(2000);

            IWebElement ButtonHome = Driver.FindElement(By.ClassName("rct-icon-expand-close"));
            Thread.Sleep(200);
            ButtonHome.Click();

            //IWebElement ButtonDesktop = Driver.FindElement(By.ClassName("rct-icon rct-icon-parent-close"));
            IWebElement ButtonDesktop = Driver.FindElement(By.XPath("//label[@for='tree-node-desktop']"));
            Thread.Sleep(2000);
            ButtonDesktop.Click();
            //Thread.Sleep(2000);

            IWebElement ButtonDocuments = Driver.FindElement(By.XPath("//label[@for='tree-node-documents']"));
            Thread.Sleep(2000);
            ButtonDocuments.Click();

            IWebElement ButtonDownload = Driver.FindElement(By.XPath("//label[@for='tree-node-downloads']"));
            Thread.Sleep(2000);
            ButtonDownload.Click();
        }

        public void RadioButton(IWebDriver Driver, IJavaScriptExecutor js)
        {
            Thread.Sleep(200);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Radio Button']")).Click();
            Thread.Sleep(2000);

            Thread.Sleep(200);
            IWebElement Yes = Driver.FindElement(By.XPath("//label[@for='yesRadio']"));
            Thread.Sleep(300);
            Yes.Click();
            Task.Delay(300).Wait();

            IWebElement impress = Driver.FindElement(By.XPath("//label[@for='impressiveRadio']"));
            Thread.Sleep(1000);
            impress.Click();
        }

        public void WebTables(IWebDriver Driver, IJavaScriptExecutor js)
        {
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Web Tables']")).Click();
            Thread.Sleep(200);

            Driver.FindElement(By.XPath("//button[@id='addNewRecordButton']")).Click();
            Thread.Sleep(200);

            IWebElement FirstName = Driver.FindElement(By.XPath("//input[@id='firstName']"));
            FirstName.SendKeys("Zubair");
            Thread.Sleep(200);

            IWebElement LastName = Driver.FindElement(By.XPath("//input[@id='lastName']"));
            LastName.SendKeys("Ahmed");
            Thread.Sleep(200);

            IWebElement Email = Driver.FindElement(By.XPath("//input[@id='userEmail']"));
            Email.SendKeys("Z123@gmail.com");
            Thread.Sleep(200);


            IWebElement Age = Driver.FindElement(By.XPath("//input[@id='age']"));
            Age.SendKeys("25");
            Thread.Sleep(200);

            IWebElement Salary = Driver.FindElement(By.XPath("//input[@id='salary']"));
            Salary.SendKeys("10000");
            Thread.Sleep(200);

            IWebElement Department = Driver.FindElement(By.XPath("//input[@id='department']"));
            Department.SendKeys("CSE");
            Thread.Sleep(200);

            Driver.FindElement(By.XPath("//button[@id='submit']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//span[@id='edit-record-2']")).Click();
            Thread.Sleep(200);

            IWebElement Clear = Driver.FindElement(By.XPath("//input[@id='userEmail']"));
            Thread.Sleep(200);
            Clear.Clear();
            Thread.Sleep(2000);


            IWebElement EdEmail = Driver.FindElement(By.XPath("//input[@id='userEmail']"));
            EdEmail.SendKeys("text@12example.com");
            Thread.Sleep(200);

            Driver.FindElement(By.XPath("//button[@id='submit']")).Click();
            Thread.Sleep(2000);


            //Driver.FindElement(By.XPath("//input[@id='searchBox']")).SendKeys(Keys.BACK_SPACE);
            //Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//span[@id='delete-record-3']")).Click();
            Thread.Sleep(200);

            Driver.FindElement(By.XPath("//input[@id='searchBox']")).SendKeys("Zu");
            Thread.Sleep(2000);

        }

        public void Buttons(IWebDriver Driver, IJavaScriptExecutor js,Actions act)
        {
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Buttons']")).Click();
            Thread.Sleep(200);
            IWebElement doubleClick = Driver.FindElement(By.Id("doubleClickBtn"));
            Thread.Sleep(2000);
            act.DoubleClick(doubleClick).Perform();

            IWebElement rightClick = Driver.FindElement(By.Id("rightClickBtn"));
            Thread.Sleep(2000);
            act.ContextClick(rightClick).Perform();


            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[text()='Click Me']")).Click();
            Thread.Sleep(2000);
        }

        public void Link(IWebDriver Driver, IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Links']")).Click();

            Driver.FindElement(By.Id("simpleLink")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("dynamicLink")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("created")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("no-content")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("moved")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("bad-request")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("unauthorized")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("bad-request")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("forbidden")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("invalid-url")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(2000);

        }

        public void BrokenLinks(IWebDriver Driver, IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Links']")).Click();

            Driver.FindElement(By.XPath("//p[text()='Valid Link']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//p[text()='Broken Link']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(2000);

        }

        public void UploadAndDownload(IWebDriver Driver, IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Links']")).Click();
            Thread.Sleep(200);

            Driver.FindElement(By.Id("downloadButton")).Click();
            Thread.Sleep(200);

            Driver.FindElement(By.Id("uploadFile")).Click();
            Thread.Sleep(200);
        }

        public void DynamicProperties(IWebDriver Driver, IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Upload and Download']")).Click();
            Thread.Sleep(200);

            Driver.FindElement(By.Id("downloadButton")).Click();
            Thread.Sleep(2000);

            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(200);

            Driver.FindElement(By.Id("uploadFile")).Click();
            Thread.Sleep(200);
            Driver.SwitchTo().Alert().Dismiss();
        }

    }
    
    
   

}
