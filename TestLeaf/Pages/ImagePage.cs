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
		IWebElement headerTag => Driver.FindElement(By.TagName("h1"));
		IWebElement imageLnk => Driver.FindElement(By.CssSelector("a[href='pages/Image.html']"));
		IWebElement imageIcn => Driver.FindElement(By.XPath("//img[@src='../images/home.png']"));
		IWebElement brokenImg => Driver.FindElement(By.CssSelector("img[src='../images/abcd.jpg']"));
		IWebElement keyboardImg => Driver.FindElement(By.XPath("//img[@src='../images/keyboard.png']"));

        public ImagePage(IWebDriver Driver) : base(Driver)
        {
        }

        public void homePageImg()
		{
			CustomMethods.Click(imageIcn);
			if (headerTag.Enabled)
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
			CustomMethods.Click(imageLnk);
			homePageImg();
			CustomMethods.isLinkWords(brokenImg, headerTag);
			CustomMethods.KeyboardActions(keyboardImg);
			CustomMethods.CustomWaitMethod(headerTag);
		}
	}
}
