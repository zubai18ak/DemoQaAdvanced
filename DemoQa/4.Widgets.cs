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
    public partial class Widgets
    {
        public void Accordian(IWebDriver Driver, IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,600)");
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//div[text()='Widgets']")).Click();
            Thread.Sleep(200);

            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Accordian']")).Click();
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//div[text()='What is Lorem Ipsum?']")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Driver.FindElement(By.XPath("//div[text()='Where does it come from?']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//div[text()='Where does it come from?']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//div[text()='Why do we use it?']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//div[text()='Why do we use it?']")).Click();
            Thread.Sleep(2000);

        }

        public void AutoComplete(IWebDriver Driver, IJavaScriptExecutor js)
        {

        }
        public void DatePicker(IWebDriver Driver, IJavaScriptExecutor js)
        {

        }
    }

}
