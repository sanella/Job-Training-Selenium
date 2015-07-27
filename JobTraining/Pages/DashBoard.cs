using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace JobTraining
{
    public class DashBoard
    {
        public static bool IsAt
        {
            get {
                var i = Driver.Instance.FindElement(By.TagName("h4"));
                if (i.Text.Equals("Welcome to the Secure Area. When you are done click logout below."))
                    return true;
                return false;
            }
        }
    }
}
