using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TestLeaf.Helpers;

namespace TestLeaf.Pages
{
	class CalendarPage : DriverHelper
	{
		IWebElement CalendarClk => Driver.FindElement(By.CssSelector("a[href='pages/Calendar.html']"));
		IWebElement CalenadarInput => Driver.FindElement(By.CssSelector("#datepicker"));
		IList<IWebElement> Dates => Driver.FindElements(By.ClassName("ui-state-default"));
		IWebElement TheTenthDay => Driver.FindElement(By.LinkText("10"));
		CustomMethods customMethods = new CustomMethods();

		public void SelectTheDate()
        {
			customMethods.Click(CalenadarInput);
            Console.WriteLine("Days: " + Dates.Count);
			customMethods.Click(TheTenthDay);

        }

		public void PerformCalendarPage()
        {
			customMethods.Click(CalendarClk);
			SelectTheDate();
			System.Threading.Thread.Sleep(500);
		}

	}
}
