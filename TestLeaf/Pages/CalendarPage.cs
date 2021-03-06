using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TestLeaf.Helpers;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
	class CalendarPage : BasePage
	{
		IWebElement CalendarClk => Driver.FindElement(By.CssSelector("a[href='pages/Calendar.html']"));
		IWebElement CalenadarInput => Driver.FindElement(By.CssSelector("#datepicker"));
		IList<IWebElement> Dates => Driver.FindElements(By.ClassName("ui-state-default"));
		IWebElement TheTenthDay => Driver.FindElement(By.LinkText("10"));


        public CalendarPage(IWebDriver Driver) : base(Driver)
        {
        }

        public void SelectTheDate()
        {
			CustomMethods.Click(CalenadarInput);
			LogUtil.Log("Days: " + Dates.Count);
			CustomMethods.Click(TheTenthDay);

        }

		public void PerformCalendarPage()
        {
			CustomMethods.Click(CalendarClk);
			SelectTheDate();
			System.Threading.Thread.Sleep(500);
		}

	}
}
