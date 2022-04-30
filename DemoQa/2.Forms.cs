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
    public partial class Forms
    {
        public void Form(IWebDriver Driver, IJavaScriptExecutor js)
        {
            Driver.FindElement(By.XPath("//div[text()='Forms']")).Click();
            Thread.Sleep(200);

            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Practice Form']")).Click();
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

            IWebElement Mobile = Driver.FindElement(By.XPath("//input[@id='userNumber']"));
            Mobile.SendKeys("1234567890");
            Thread.Sleep(200);

            IWebElement Sub = Driver.FindElement(By.XPath("//input[@id='subjectsContainer']"));
            Sub.SendKeys("Z123@gmail.com");
            Thread.Sleep(200);
        }
    }

}
