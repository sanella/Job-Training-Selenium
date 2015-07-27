using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Threading;

namespace JobTraining
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://the-internet.herokuapp.com/login");

        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }

        public class LoginCommand
        {
            public readonly string userName;
            public string password;

            public LoginCommand(string userName)
            {
                this.userName = userName;
            }

            public LoginCommand WithPassword(string password)
            {
                this.password = password;
                return this;
            }

            public void Login()
            {
                var usernameInput = Driver.Instance.FindElement(By.Id("username"));
                usernameInput.SendKeys(userName);
                Thread.Sleep(5);

                var passworInput = Driver.Instance.FindElement(By.Id("password"));
                passworInput.SendKeys(password);

                var submit = Driver.Instance.FindElement(By.TagName("i"));
                submit.Click();  
            }
        }
    }
}
