using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestSelectablePage : BaseTest
    {
        [Test]
        public void TestSelectable()
        {
            SelectablePage selectablePage = new SelectablePage(Driver);
            selectablePage.PerformSelectablePage();
        }
    }
}
