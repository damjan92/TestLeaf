using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;
using TestLeaf.Helpers;

namespace TestLeaf.Pages
{
	class WebTablePage : DriverHelper
	{
		IWebElement WebTableClk => Driver.FindElement(By.CssSelector("a[href='pages/sorttable.html']"));

        readonly IReadOnlyCollection<IWebElement> ListofNames = Driver.FindElements(By.ClassName("sorting_1"));

		CustomMethods customMethods = new CustomMethods();

		
		public void getNames()
		{
            foreach (var item in ListofNames)
            {
                Console.WriteLine(item.Text);
			}
		}


		public void PerformWebTeblePage()
		{
			customMethods.Click(WebTableClk);
			Thread.Sleep(500);
			getNames();
		}

	}
}
