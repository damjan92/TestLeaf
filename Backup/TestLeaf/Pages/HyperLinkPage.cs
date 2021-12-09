using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
    class HyperLinkPage : BasePage
    {
        public HyperLinkPage(IWebDriver Driver) : base(Driver)
        {
        }

        IWebElement hyperLinkClk => Driver.FindElement(By.XPath("//a[@href='pages/Link.html']"));
        IWebElement homepagelnk => Driver.FindElement(By.XPath("//div[@id='contentblock']//div[1]//div[1]//div[1]//a[1]"));
		IWebElement headerTag => Driver.FindElement(By.TagName("h1"));
		IWebElement destinationLnk => Driver.FindElement(By.PartialLinkText("Find where am suppos"));
		IWebElement isBroken => Driver.FindElement(By.CssSelector("a[href='error.html']"));
		IWebElement httpStatus => Driver.FindElement(By.TagName("h1"));


		public void homePageLink()
		{
			CustomMethods.Click(homepagelnk);
			if (headerTag.Displayed)
			{
				LogUtil.Log("Home page link works");
				Driver.Navigate().Back();
			}
			else
			{
				LogUtil.Log("HomePage link doesnt work");
				CustomMethods.TakeScreenshot(homepagelnk);
			}
		}

		public void CheckDestination()
        {
			CustomMethods.Click(destinationLnk);
			var dest = Driver.Url;
			LogUtil.Log("URL is: " + dest);
			Driver.Navigate().Back();
		}

		public bool CheckAvailability()
        {
			CustomMethods.Click(isBroken);
			if (httpStatus.Text.Contains("404"))
            {
				LogUtil.Log("Site is not available, msg is 404");
				Driver.Navigate().Back();
				return false;
            } 
			else
            {
				LogUtil.Log("Site is available");
				return true;
			}
        }

		public void PerformHyperLink()
        {
			CustomMethods.Click(hyperLinkClk);
			homePageLink();
			CheckDestination();
			CheckAvailability();

		}
	}
}
