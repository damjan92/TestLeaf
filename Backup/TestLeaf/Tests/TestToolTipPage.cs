using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestToolTipPage : BaseTest
    {
        [Test]
        public void TestToolTip()
        {
            ToolTipPage toolTipPage = new ToolTipPage(Driver);
            toolTipPage.PerformToolTipPage();
        }
    }
}
