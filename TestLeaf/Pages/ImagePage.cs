using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using TestLeaf.Helpers;

namespace TestLeaf.Pages
{
	class ImagePage : DriverHelper
	{
		IWebElement headerTag => Driver.FindElement(By.TagName("h1"));
		IWebElement imageLnk => Driver.FindElement(By.CssSelector("a[href='pages/Image.html']"));
		IWebElement imageIcn => Driver.FindElement(By.XPath("//img[@src='../images/home.png']"));
		IWebElement brokenImg => Driver.FindElement(By.CssSelector("img[src='../images/abcd.jpg']"));
		IWebElement keyboardImg => Driver.FindElement(By.XPath("//img[@src='../images/keyboard.png']"));

		CustomMethods customMethods = new CustomMethods();
		CustomLogger customLogger = new CustomLogger();


		public void homePageImg()
		{
			customMethods.Click(imageIcn);
			if (headerTag.Enabled)
			{
				customLogger.LogInfo("Home page Image works");
				Driver.Navigate().Back();
			}
			else
			{
				customLogger.LogWarn("HomePage Image doesnt work");
			}
		}

		public void PerformImagePage()
		{
			customMethods.Click(imageLnk);
			homePageImg();
			customMethods.isLinkWords(brokenImg, headerTag);
			customMethods.KeyboardActions(keyboardImg);
			customMethods.CustomWaitMethod(headerTag);
		}
	}
}
