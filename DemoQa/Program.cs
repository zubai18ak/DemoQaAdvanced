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
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com");
            Driver.Manage().Window.Maximize();
            Actions act = new Actions(Driver);
            Thread.Sleep(1000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(200);
            Elements TextBox = new Elements();
            Elements CheckBox = new Elements();
            Elements RadioButton = new Elements();
            Elements WebTables = new Elements();
            Elements Buttons = new Elements();
            Elements Link = new Elements();
            Elements BrokenLinks = new Elements();
            Elements UploadAndDownload = new Elements();
            Elements DynamicProperties = new Elements();
            Forms Form = new Forms();
            AlertsFrameWindow BrowserWindow = new AlertsFrameWindow();
            AlertsFrameWindow Alerts = new AlertsFrameWindow();
            AlertsFrameWindow TimerAlert = new AlertsFrameWindow();
            AlertsFrameWindow Modals = new AlertsFrameWindow();

            TextBox.TextBox(Driver, js);
            CheckBox.CheckBox(Driver, js);
            RadioButton.RadioButton(Driver, js);
            WebTables.WebTables(Driver, js);
            Buttons.Buttons(Driver, js, act);
            Link.Link(Driver, js);
            BrokenLinks.BrokenLinks(Driver, js);
            UploadAndDownload.UploadAndDownload(Driver, js);
            DynamicProperties.DynamicProperties(Driver, js);
            Form.Form(Driver, js);
            Alerts.BrowserWindow(Driver, js, act);
            Alerts.Alerts(Driver, js, act);
            Alerts.TimerAlert(Driver, js, act);
            Alerts.Modals(Driver, js, act);


            Console.WriteLine("Testing Close");
            Thread.Sleep(200);
            Driver.Close();
            Thread.Sleep(2000);
            Driver.Quit();


        }
    }
}
