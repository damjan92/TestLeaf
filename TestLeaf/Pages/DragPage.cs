using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestLeaf.Pages
{
	class DragPage : DriverHelper
	{
		IWebElement DragClk => Driver.FindElement(By.CssSelector("a[href='pages/drag.html']"));
		IWebElement DragElement => Driver.FindElement(By.CssSelector("#draggable"));

		CustomMethods customMethods = new CustomMethods();

		public void Draging()
        {
			Actions actions = new Actions(Driver);
			actions.DragAndDropToOffset(DragElement, 200, 50)
				.Build()
				.Perform();
        }

		public void PerformDragPage()
        {
			customMethods.Click(DragClk);
			Draging();

		}
	}
}
