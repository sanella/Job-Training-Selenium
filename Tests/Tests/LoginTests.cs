using JobTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class LoginTests : BaseTests
    {
       

        [TestMethod]
        public void TestMethod1()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("tomsmith").WithPassword("SuperSecretPassword!").Login();

            Assert.IsTrue(DashBoard.IsAt, "You are stupid");
        }
    }
}
