using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using System.Threading;
using System.Collections.ObjectModel;

namespace TestLeaf.Pages
{
	// Todo
	class WindowPage : DriverHelper
	{
		IWebElement WindowClick => Driver.FindElement(By.CssSelector("a[href='pages/Window.html']"));
		IWebElement homePageBtn => Driver.FindElement(By.CssSelector("#home"));


		CustomMethods customMethods = new CustomMethods();

		
		public void CheckNewWindowHp()
		{
			//string expected_url = "http://www.leafground.com/home.html";
			customMethods.Click(homePageBtn);

			
		}

		public void PerformWindowPage()
		{
			customMethods.Click(WindowClick);
		}

	}
}
