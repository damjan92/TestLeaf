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
            ButtonPage.homePageButton();
        }

        [Test]
        public void GetButtonPositon()
        {
            ButtonPage ButtonPage = new ButtonPage(Driver);
            var result = ButtonPage.getButtonPositon();
            Assert.AreEqual(240, result.X);
            Assert.AreEqual(240, result.Y);
        }

        [Test]
        public void GetButtonColour()
        {
            ButtonPage ButtonPage = new ButtonPage(Driver);
            ButtonPage.getButtonColour();
        }

        [Test]
        public void GetButtonDimension()
        {
            ButtonPage ButtonPage = new ButtonPage(Driver);
            ButtonPage.getButtonDimension();
        }
    }
}
