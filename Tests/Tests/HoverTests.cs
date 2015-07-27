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
    public class HoverTests : BaseTests
    {

        [TestMethod]
        public void HoverPageTest()
        {
            HoverPage.GoTo();
            HoverPage.FigureChose(0);

            Assert.IsTrue(UserProfilePage.IsAt, "Error in hover test page");
        }
    }
}
