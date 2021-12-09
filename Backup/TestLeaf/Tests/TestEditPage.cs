using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestEditPage : BaseTest
    {

        [Test]
        public void TestEdit()
        {
            EditPage editPage = new EditPage(Driver);
            editPage.PerformEditPage("New Text", "Append Text");
        }
    }
}
