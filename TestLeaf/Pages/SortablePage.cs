using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestLeaf.Pages
{
	class SortablePage : DriverHelper
	{
		IWebElement SortableClk => Driver.FindElement(By.CssSelector("a[href='pages/sortable.html']"));
		IWebElement ItemOne => Driver.FindElement(By.CssSelector("div[id='mydiv'] li:nth-child(1)"));
		IWebElement ItemTwo => Driver.FindElement(By.CssSelector("li:nth-child(7)"));

		CustomMethods customMethods = new CustomMethods();

		public void SortTheFirstItem()
		{
			Actions actions = new Actions(Driver);

			actions.ClickAndHold(ItemOne).MoveByOffset(0, 100).Release()
				.Build()
				.Perform();
		}

		public void SortTheSecondItem()
		{
			Actions actions = new Actions(Driver);

			actions.ClickAndHold(ItemTwo).MoveByOffset(0, -50).Release()
				.Build()
				.Perform();
		}

		public void PerformSortablePage()
		{
			customMethods.Click(SortableClk);
			SortTheFirstItem();
			SortTheSecondItem();
		}
	}
}
