using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace JobTraining
{
    public class Driver
    {
        public static IWebDriver Instance { get;  set; }

        public static void Initialized()
        {
            Instance = new FirefoxDriver();
            turnOnWait();
        }

        public static void Close()
        {
            Instance.Close();
        }

        public static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int) timeSpan.TotalSeconds * 100);
        }

        public static void NoWait(Action action)
        {
            turnOffWait();
            action();
            turnOnWait();
        }

        private static void turnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        private static void turnOffWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));

        }
    }
}
