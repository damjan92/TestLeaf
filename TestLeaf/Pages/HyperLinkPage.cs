using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;

namespace TestLeaf.Pages
{
    class HyperLinkPage : DriverHelper
    {
		IWebElement hyperLinkClk => Driver.FindElement(By.XPath("//a[@href='pages/Link.html']"));
        IWebElement homepagelnk => Driver.FindElement(By.XPath("//div[@id='contentblock']//div[1]//div[1]//div[1]//a[1]"));
		IWebElement headerTag => Driver.FindElement(By.TagName("h1"));
		IWebElement destinationLnk => Driver.FindElement(By.PartialLinkText("Find where am suppos"));
		IWebElement isBroken => Driver.FindElement(By.CssSelector("a[href='error.html']"));
		IWebElement httpStatus => Driver.FindElement(By.TagName("h1"));

		CustomMethods customMethods = new CustomMethods();
		CustomLogger customLogger = new CustomLogger();

		public void homePageLink()
		{
			customMethods.Click(homepagelnk);
			if (headerTag.Displayed)
			{
				customLogger.LogInfo("Home page link works");
				Driver.Navigate().Back();
			}
			else
			{
				customLogger.LogWarn("HomePage link doesnt work");
				customMethods.TakeScreenshot(homepagelnk);
			}
		}

		public void CheckDestination()
        {
			customMethods.Click(destinationLnk);
			var dest = Driver.Url;
			customLogger.LogInfo("URL is: " + dest);
			Driver.Navigate().Back();
		}

		public bool CheckAvailability()
        {
			customMethods.Click(isBroken);
			if (httpStatus.Text.Contains("404"))
            {
				customLogger.LogInfo("Site is not available, msg is 404");
				Driver.Navigate().Back();
				return false;
            } 
			else
            {
				customLogger.LogInfo("Site is available");
				return true;
			}
        }

		public void PerformHyperLink()
        {
			customMethods.Click(hyperLinkClk);
			homePageLink();
			CheckDestination();
			CheckAvailability();

		}
	}
}
