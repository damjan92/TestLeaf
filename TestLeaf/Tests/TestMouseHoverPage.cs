using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestMouseHoverPage : BaseTest
    {
        [Test]
        public void TestMouseHover()
        {
            MouseHoverPage mouseHoverPage = new MouseHoverPage(Driver);
            mouseHoverPage.PerformHover();
        }
    }
}
