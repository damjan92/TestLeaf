using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;
using TestLeaf.Helpers;
using OpenQA.Selenium.Support.UI;

namespace TestLeaf.Pages
{
	class WaitMethods : DriverHelper
	{

		IWebElement WaitToDisappearClk => Driver.FindElement(By.CssSelector("a[href='pages/disapper.html']"));
		IWebElement DisappearingBtn => Driver.FindElement(By.CssSelector("b"));

		IWebElement WaitToAppearClk => Driver.FindElement(By.CssSelector("a[href='pages/appear.html']"));
		IWebElement AppearingBtn => Driver.FindElement(By.CssSelector("#btn"));

		IWebElement WaitToChangeClk => Driver.FindElement(By.CssSelector("a[href='pages/TextChange.html']"));
		IWebElement ChangingBtn => Driver.FindElement(By.CssSelector("#btn"));


		CustomMethods customMethods = new CustomMethods();

	   

		public void PerformWaitToDisappear()
		{
			customMethods.Click(WaitToDisappearClk);
			customMethods.CustomWaitMethodDisappear(DisappearingBtn);
			Driver.Navigate().Back();
		}

		public void PerformWaitToAppear()
		{
			customMethods.Click(WaitToAppearClk);
			customMethods.CustomWaitMethod(AppearingBtn);
			Driver.Navigate().Back();
		}

		public void PerformWaitForChange()
		{
			customMethods.Click(WaitToChangeClk);

			WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
			wait.Until(d =>
			{
				if (ChangingBtn.Displayed && ChangingBtn.Text.Contains("Click"))
				{
					Console.WriteLine("Element is changed");
					return ChangingBtn;
				}
				return null;
			});

		}

	}
}
