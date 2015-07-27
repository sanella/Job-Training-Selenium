using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;

namespace JobTraining
{
    public class HoverPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://the-internet.herokuapp.com/hovers");
        }

        public static void FigureChose(int link)
        {
            var hover = Driver.Instance.FindElements(By.CssSelector("div.figure img"))[link];
            var elementToClick = Driver.Instance.FindElement(By.CssSelector("div.figcaption a"));
            //hover odglumiti

            Actions action = new Actions(Driver.Instance);
            action.MoveToElement(hover).Perform();
            action.MoveToElement(elementToClick).Click().Perform();

   
        }
    }
}
