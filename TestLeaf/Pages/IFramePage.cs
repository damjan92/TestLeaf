using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestLeaf.Helpers;
using OpenQA.Selenium;


namespace TestLeaf.Pages
{
	class IFramePage : DriverHelper
	{
		IWebElement IframeClk => Driver.FindElement(By.CssSelector("a[href='pages/frame.html']"));
		IWebElement FirstFrame => Driver.FindElement(By.XPath("//iframe[@src='default.html']"));
		IWebElement FrameClick => Driver.FindElement(By.CssSelector("#Click"));
		IWebElement SecondFrame => Driver.FindElement(By.XPath("//iframe[@src='page.html']"));
		IWebElement NestedFrame => Driver.FindElement(By.XPath("//iframe[@id='frame2']"));
		IList<IWebElement> Iframes => Driver.FindElements(By.XPath("//iframe"));
		IWebElement SecondFrClk => Driver.FindElement(By.CssSelector("#Click1"));

		CustomMethods customMethods = new CustomMethods();
		CustomLogger customLogger = new CustomLogger();

		public void iframeClick()
		{
			Driver.SwitchTo().Frame(FirstFrame);
			customMethods.Click(FrameClick);
			if (FrameClick.Text.Contains("Clicked"))
			{
				customLogger.LogInfo("You clicked the button");
			}
			else
			{
				customLogger.LogWarn("You missed the frame");
			}
			Driver.SwitchTo().DefaultContent();
		}

		public void SecondIframeClick()
		{
			Driver.SwitchTo().Frame(SecondFrame);
			Driver.SwitchTo().Frame(NestedFrame);
			customMethods.Click(SecondFrClk);
			if (SecondFrClk.Text.Contains("Clicked"))
			{
				customLogger.LogInfo("You clicked the button");
			}
			else
			{
				customLogger.LogWarn("You missed the frame");
			}
			Driver.SwitchTo().DefaultContent();
		}

		public void NumOfIframes()
		{ 
			Console.WriteLine(Iframes.Count);
		}

        public void PerformIFramePage()
		{
			customMethods.Click(IframeClk);
			iframeClick();
			SecondIframeClick();
			NumOfIframes();
		}
	}
}
