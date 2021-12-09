using System;
using NUnit.Framework;
using TestLeaf.Base;
using TestLeaf.Pages;

namespace TestLeaf.Tests
{
	[TestFixture]
	public class TestButtonPage : BaseTest
	{
		
        [Test]
        public void TestHomePageButton()
        {
            ButtonPage ButtonPage = new ButtonPage(Driver);
            var result = ButtonPage.homePageButton();
            Assert.NotNull(result,"Home Page hasn't opened");
        }

        [Test]
        public void GetButtonPositonByX()
        {
            ButtonPage ButtonPage = new ButtonPage(Driver);
            var result = ButtonPage.getButtonPositon();
            Assert.AreEqual(240, result.X);
        }

        [Test]
        public void GetButtonPositonByY()
        {
            ButtonPage ButtonPage = new ButtonPage(Driver);
            var result = ButtonPage.getButtonPositon();
            Assert.AreEqual(304, result.Y);
        }

		[Test]
		public void GetButtonPositon()
		{
			ButtonPage ButtonPage = new ButtonPage(Driver);
			var result = ButtonPage.getButtonPositon();
			Assert.Multiple(() =>
			{
				Assert.AreEqual(240, result.X);
				Assert.AreEqual(304, result.Y);
			});
		}

		[Test]
        public void GetButtonColour()
        {
            ButtonPage ButtonPage = new ButtonPage(Driver);
            var result = ButtonPage.getButtonColour();
            string RgbaFormat = "rgba(144, 238, 144, 1)";
            Assert.AreEqual(RgbaFormat, result);
        }

        [Test]
        public void GetButtonDimension()
        {
            ButtonPage ButtonPage = new ButtonPage(Driver);
            var result = ButtonPage.getButtonDimension();
            Assert.AreEqual(20, result.Height);
            Assert.AreEqual(122, result.Width);
        }
    }
}
