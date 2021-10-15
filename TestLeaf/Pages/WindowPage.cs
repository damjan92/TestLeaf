using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using System.Threading;

namespace TestLeaf.Pages
{
	class WindowPage : DriverHelper
	{
		IWebElement WindowClick => Driver.FindElement(By.CssSelector("a[href='pages/Window.html']"));
		IWebElement homePageBtn => Driver.FindElement(By.CssSelector("#home"));


		CustomMethods customMethods = new CustomMethods();

		public void CheckNewWindowHp()
		{
			customMethods.Click(homePageBtn);
			
		}

		public void PerformWindowPage()
		{
			customMethods.Click(WindowClick);
			//IWebElement newWindow = Driver.SwitchTo().Window(Driver.WindowHandles);
		}

	}
}
