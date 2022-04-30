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
    public partial class AlertsFrameWindow
    {
        public void BrowserWindow(IWebDriver Driver, IJavaScriptExecutor js, Actions act)
        {
            js.ExecuteScript("window.scrollBy(0,400)");
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//span[text()='Browser Windows']")).Click();

            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='tabButton']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            Thread.Sleep(2000);
            Driver.Close();

            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[text()='New Window']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            Thread.Sleep(2000);
            Driver.Close();

            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[text()='New Window Message']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            Thread.Sleep(2000);
            Driver.Close();
        }
        public void Alerts(IWebDriver Driver, IJavaScriptExecutor js, Actions act)
        {
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Alerts']")).Click();
            Thread.Sleep(200);

            Driver.FindElement(By.XPath("//button[@id='alertButton']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();

            Driver.FindElement(By.XPath("//button[@id='confirmButton']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();

            Driver.FindElement(By.XPath("//button[@id='confirmButton']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Dismiss();

            Driver.FindElement(By.XPath("//button[@id='promtButton']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().GetType();
            Driver.SwitchTo().Alert().SendKeys("Zubair Ahmed");
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }
        public void TimerAlert(IWebDriver Driver, IJavaScriptExecutor js, Actions act)
        {

        }
        public void Modals(IWebDriver Driver, IJavaScriptExecutor js, Actions act)
        {
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Modals']")).Click();
            Thread.Sleep(200);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            Thread.Sleep(200);
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Modal Dialogs']")).Click();
            Thread.Sleep(200);

            Thread.Sleep(200);
            Driver.FindElement(By.Id("showSmallModal")).Click();
            Thread.Sleep(200);

            string sm1 = Driver.FindElement(By.ClassName("modal-header")).Text;
            Console.WriteLine("Modal Header" + sm1);
            Thread.Sleep(200);

            string sm2 = Driver.FindElement(By.ClassName("modal-body")).Text;
            Console.WriteLine("Modal Body" + sm2);
            Thread.Sleep(200);

            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//button[@id='closeSmallModal']")).Click();
            Thread.Sleep(200);

            Thread.Sleep(200);
            Driver.FindElement(By.Id("showLargeModal")).Click();
            Thread.Sleep(200);

            string bm1 = Driver.FindElement(By.ClassName("modal-header")).Text;
            Console.WriteLine("Modal Header" + bm1);
            Thread.Sleep(200);

            string bm2 = Driver.FindElement(By.ClassName("modal-body")).Text;
            Console.WriteLine("Modal Body" + bm2);
            Thread.Sleep(200);

            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//button[@id='closeLargeModal']")).Click();
            Thread.Sleep(200);

        }

    }

}
