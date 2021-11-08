using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestTablePage : BaseTest
    {
        [Test]
        public void TestTable()
        {
            TablePage tablePage = new TablePage(Driver);
            tablePage.PerformTablePage();
        }
    }
}
