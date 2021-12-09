using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
	[TestFixture]
	class TestImagePage : BaseTest
	{
		[Test]
		public void TestImage()
		{
			ImagePage imagePage = new ImagePage(Driver);
			var result = imagePage.HomePageImg();
			Assert.IsTrue(result);
		}

		[Test]
		public void TestIsImageLinkWorks()
		{
			ImagePage imagePage = new ImagePage(Driver);
			var result = imagePage.IsImageLinkWorks();
			Assert.IsTrue(result);
		}

		[Test]
		public void TestImageKeyboardActions()
		{
			ImagePage imagePage = new ImagePage(Driver);
			imagePage.ImageKeyboardActions();
			Assert.AreEqual("http://www.leafground.com/home.html", "http://www.leafground.com/home.html");
		}

	}
}
