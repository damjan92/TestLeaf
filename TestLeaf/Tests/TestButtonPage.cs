using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestButtonPage : BaseTest
    {
        [Test]
        public void TestButton()
        {
            ButtonPage buttonPage = new ButtonPage(Driver);
            buttonPage.PerformButtonPage();
        }
    }
}
