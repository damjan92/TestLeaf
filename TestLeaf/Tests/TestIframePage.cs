using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestIframePage : BaseTest
    {
        [Test]
        public void TestIFrame()
        {
            IFramePage framePage = new IFramePage(Driver);
            framePage.PerformIFramePage();
        }
    }
}
