using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestDropdownPage : BaseTest
    {
        [Test]
        public void TestDropdown()
        {
            DropdownPage dropdownPage = new DropdownPage(Driver);
            dropdownPage.PerformDropdownPage();
        }
    }
}
