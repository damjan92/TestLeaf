using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
	class IFramePage : BasePage
	{
		IWebElement IframeClk => Driver.FindElement(By.CssSelector("a[href='pages/frame.html']"));
		IWebElement FirstFrame => Driver.FindElement(By.XPath("//iframe[@src='default.html']"));
		IWebElement FrameClick => Driver.FindElement(By.CssSelector("#Click"));
		IWebElement SecondFrame => Driver.FindElement(By.XPath("//iframe[@src='page.html']"));
		IWebElement NestedFrame => Driver.FindElement(By.XPath("//iframe[@id='frame2']"));
		IList<IWebElement> Iframes => Driver.FindElements(By.XPath("//iframe"));
		IWebElement SecondFrClk => Driver.FindElement(By.CssSelector("#Click1"));

		
        public IFramePage(IWebDriver Driver) : base(Driver)
        {
        }

        public void iframeClick()
		{
			Driver.SwitchTo().Frame(FirstFrame);
			CustomMethods.Click(FrameClick);
			if (FrameClick.Text.Contains("Clicked"))
			{
				LogUtil.Log("You clicked the button");
			}
			else
			{
				LogUtil.Log("You missed the frame");
			}
			Driver.SwitchTo().DefaultContent();
		}

		public void SecondIframeClick()
		{
			Driver.SwitchTo().Frame(SecondFrame);
			Driver.SwitchTo().Frame(NestedFrame);
			CustomMethods.Click(SecondFrClk);
			if (SecondFrClk.Text.Contains("Clicked"))
			{
				LogUtil.Log("You clicked the button");
			}
			else
			{
				LogUtil.Log("You missed the frame");
			}
			Driver.SwitchTo().DefaultContent();
		}

		public void NumOfIframes()
		{
			LogUtil.Log("Number of iframes: " + Iframes.Count);
		}

        public void PerformIFramePage()
		{
			CustomMethods.Click(IframeClk);
			iframeClick();
			SecondIframeClick();
			NumOfIframes();
		}
	}
}
