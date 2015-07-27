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
    public class StatusCodeTests : BaseTests
    {
        [TestMethod]
        public void StatusCodeTest()
        {
            string link = "200";
            StatusCode.GoTo();
            StatusCode.ChosenLinks(link);

            Assert.IsTrue(StatusBoard.IsAt(link), "Error in status code tests");
        }
    }
}
