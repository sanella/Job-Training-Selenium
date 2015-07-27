using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace JobTraining
{
    public class UserProfilePage
    {
        public static bool IsAt { get
            {
                var notFounf = Driver.Instance.FindElement(By.TagName("h1"));
                if (notFounf.Text.Equals("Not Found"))
                    return true;
                return false;
            }
        }
    }
}
