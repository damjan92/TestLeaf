using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestHyperlinkPage : BaseTest
    {
        [Test]
        public void TestHyperlink()
        {
            HyperLinkPage hyperLinkPage = new HyperLinkPage(Driver);
            hyperLinkPage.PerformHyperLink();
        }
    }
}
