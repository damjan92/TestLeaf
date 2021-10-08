using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestLeaf.Helpers;
using TestLeaf.Pages;

namespace TestLeaf
{
	public class Tests : DriverHelper
	{
		[SetUp]
		public void Setup()
		{
			Driver = new ChromeDriver();
			Driver.Navigate().GoToUrl("http://www.leafground.com/");
			Driver.Manage().Window.Maximize();
		}

		//TODO Fix the getText method
		[Test]
		public void Edit()
		{
			EditPage editPage = new EditPage();
			editPage.PerformEditPage("email@email", "appende text");
			Assert.Pass();
		}

		[Test]
		public void Button()
        {
			ButtonPage buttonPage = new ButtonPage();
			buttonPage.PerformButtonPage();
			Assert.Pass();
		}

		[Test]
		public void HyperLinks()
        {
			HyperLinkPage hyperLinkPage = new HyperLinkPage();
			hyperLinkPage.PerformHyperLink();
			Assert.Pass();
        }

		[TearDown]
		public void Clean()
        {
			Driver.Quit();
		}
	}
}