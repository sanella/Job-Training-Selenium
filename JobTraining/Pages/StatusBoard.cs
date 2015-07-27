using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace JobTraining
{
    public class StatusBoard
    {
        public static bool IsAt(string link)
        {
            var statusTitle = Driver.Instance.FindElement(By.TagName("p"));
            if (statusTitle.Text.Contains(link))
                return true;
            return false;
         }
    }
}
