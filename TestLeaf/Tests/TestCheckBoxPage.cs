using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestCheckBoxPage : BaseTest
    {
        [Test]
        public void TestCheckBox()
        {
            CheckboxPage checkboxPage = new CheckboxPage(Driver);
            checkboxPage.PerformCheckBoxPage();
        }
    }
}
