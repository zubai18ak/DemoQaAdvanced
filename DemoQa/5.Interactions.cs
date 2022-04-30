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
    public partial class Interactions
    {
        public void Sortable(IWebDriver Driver, IJavaScriptExecutor js, Actions act)
        {
            js.ExecuteScript("window.scrollBy(0,600)");
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Interactions']")).Click();
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Sortable']")).Click();
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//a[@id='demo-tab-list']")).Click();
            Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//div[text()='Two']"));
            var drag = Driver.FindElement(By.XPath("//div[text()='One']"));
            var drop = Driver.FindElement(By.XPath("//div[text()='Two']"));
            act.ClickAndHold(drag).Build().Perform();
            Thread.Sleep(200);
            act.DragAndDrop(drag, drop).Build().Perform();
            Thread.Sleep(200);

            act.MoveToElement(drop).Release().Build();
            Thread.Sleep(200);
        }
    }


}
