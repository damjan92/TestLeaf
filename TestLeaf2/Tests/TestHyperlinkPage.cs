using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestHyperlinkPage : BaseTest
    {
        [Test]
        public void TestHomePageLink()
        {
            HyperLinkPage hyperLinkPage = new HyperLinkPage(Driver);
            var result = hyperLinkPage.HomePageLink();
			Assert.NotNull(result, "Wrong destination");
        }

		[Test]
		public void TestDestionationOfLink()
		{
			HyperLinkPage hyperLinkPage = new HyperLinkPage(Driver);
			var result = hyperLinkPage.CheckDestination();
			Assert.AreEqual("http://www.leafground.com/pages/Button.html", result, "URL doesnt match");
		}

		[Test]
		public void TestAvailabiltyOfLink()
		{
			HyperLinkPage hyperLinkPage = new HyperLinkPage(Driver);
			var result = hyperLinkPage.CheckAvailability();
			Assert.IsFalse(result);
		}
    }
}
