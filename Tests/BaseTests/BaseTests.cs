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
    public class BaseTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialized();
        }

        [TestCleanup]
        public void Close()
        {
            Driver.Close();
        }
    }
}
