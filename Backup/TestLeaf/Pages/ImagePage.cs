using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using TestLeaf.Base;
using TestLeaf.Helpers;

namespace TestLeaf.Pages
{
	class ImagePage : BasePage
	{
		IWebElement HeaderTag => Driver.FindElement(By.TagName("h1"));
		IWebElement ImageLnk => Driver.FindElement(By.CssSelector("a[href='pages/Image.html']"));
		IWebElement ImageIcn => Driver.FindElement(By.XPath("//img[@src='../images/home.png']"));
		IWebElement BrokenImg => Driver.FindElement(By.CssSelector("img[src='../images/abcd.jpg']"));
		IWebElement KeyboardImg => Driver.FindElement(By.XPath("//img[@src='../images/keyboard.png']"));

        public ImagePage(IWebDriver driver) : base(driver)
        {
			Driver = driver;
		}

        public void homePageImg()
		{
			CustomMethods.Click(ImageIcn);
			if (HeaderTag.Enabled)
			{
				LogUtil.Log("Home page Image works");
				Driver.Navigate().Back();
			}
			else
			{
				LogUtil.Log("HomePage Image doesnt work");
			}
		}

		public void PerformImagePage()
		{
			CustomMethods.Click(ImageLnk);
			homePageImg();
			CustomMethods.IsLinkWords(BrokenImg, HeaderTag);
			CustomMethods.KeyboardActions(KeyboardImg, Driver);
			CustomMethods.CustomWaitMethod(HeaderTag, Driver);
		}
	}
}
