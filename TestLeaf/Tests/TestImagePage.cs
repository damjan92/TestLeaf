using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestImagePage : BaseTest
    {
        [Test]
        public void TestImage()
        {
            ImagePage imagePage = new ImagePage(Driver);
            imagePage.PerformImagePage();
        }
    }
}
