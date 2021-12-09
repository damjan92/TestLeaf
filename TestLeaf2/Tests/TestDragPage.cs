using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;


namespace TestLeaf.Tests
{
    [TestFixture]
    class TestDragPage : BaseTest
    {
        [Test]
        public void TestDrag()
        {
            DragPage dragPage = new DragPage(Driver);
            var result = dragPage.Draging();
			Assert.IsTrue(result);
        }
    }
}
