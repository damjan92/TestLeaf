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

		public void homePageImg()
		{
			customMethods.Click(imageIcn);
			if (headerTag.Enabled)
			{
				Console.WriteLine("Home page Image works");
				Driver.Navigate().Back();
			}
			else
			{
				Console.WriteLine("HomePage Image doesnt work");
			}
		}

		public void PerformImagePage()
		{
			customMethods.Click(imageLnk);
			homePageImg();
			customMethods.isLinkWords(brokenImg, headerTag);
			customMethods.KeyboardActions(keyboardImg);
			customMethods.CustomWaitMethod(headerTag);
			Thread.Sleep(1500);
		}
	}
}
