using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA;

namespace JobTraining
{
    public class StatusCode
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://the-internet.herokuapp.com/status_codes");

        }

        public static void ChosenLinks(string link)
        {
            var linkChosen = Driver.Instance.FindElement(By.LinkText(link));
            linkChosen.Click();
        }
    }
}
