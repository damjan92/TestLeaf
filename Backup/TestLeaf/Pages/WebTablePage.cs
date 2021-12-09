using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;
using TestLeaf.Helpers;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
	class WebTablePage : BasePage
	{
		IWebElement WebTableClk => Driver.FindElement(By.CssSelector("a[href='pages/sorttable.html']"));

        readonly IReadOnlyCollection<IWebElement> ListofNames = Driver.FindElements(By.ClassName("sorting_1"));

        public WebTablePage(IWebDriver Driver) : base(Driver)
        {
        }

        public void getNames()
		{
            foreach (var item in ListofNames)
            {
                Console.WriteLine(item.Text);
			}
		}


		public void PerformWebTeblePage()
		{
			CustomMethods.Click(WebTableClk);
			Thread.Sleep(500);
			getNames();
		}

	}
}
