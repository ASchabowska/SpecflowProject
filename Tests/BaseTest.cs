using CoupleFramework;
using CoupleFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class BaseTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            HomePage.GoTo();
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Close();
        }
    }
}
