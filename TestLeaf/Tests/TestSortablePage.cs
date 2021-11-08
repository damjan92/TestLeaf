using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestSortablePage : BaseTest
    {
        [Test]
        public void TestSort()
        {
            SortablePage sortablePage = new SortablePage(Driver);
            sortablePage.PerformSortablePage();
        }
    }
}
