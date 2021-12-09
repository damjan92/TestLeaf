using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using System.Threading;
using System.Collections.ObjectModel;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
	// Todo
	class WindowPage : BasePage
	{
		IWebElement WindowClick => Driver.FindElement(By.CssSelector("a[href='pages/Window.html']"));
		IWebElement homePageBtn => Driver.FindElement(By.CssSelector("#home"));

        public WindowPage(IWebDriver Driver) : base(Driver)
        {
        }

        public void CheckNewWindowHp()
		{
			//string expected_url = "http://www.leafground.com/home.html";
			CustomMethods.Click(homePageBtn);

			
		}

		public void PerformWindowPage()
		{
			CustomMethods.Click(WindowClick);
		}

	}
}
