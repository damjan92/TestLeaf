using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestIframePage : BaseTest
    {
        [Test]
        public void TestIFrame()
        {
            IFramePage framePage = new IFramePage(Driver);
            var result = framePage.IframeClick();
			Assert.IsTrue(result);
        }

		[Test]
		public void TestSecondIframeClick()
		{
			IFramePage framePage = new IFramePage(Driver);
			var result = framePage.SecondIframeClick();
			Assert.IsTrue(result);
		}

		[Test]
		public void TestNumberOfIframes()
		{
			IFramePage framePage = new IFramePage(Driver);
			var result = framePage.NumOfIframes();
			Assert.AreEqual(3, result, "Number of iframes doesnt match");
		}
    }
}
