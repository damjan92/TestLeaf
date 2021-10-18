using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestLeaf.Pages
{
	class DropPage : DriverHelper
	{
		IWebElement DropClk => Driver.FindElement(By.CssSelector("a[href='pages/drop.html']"));
		IWebElement DragElement => Driver.FindElement(By.CssSelector("#draggable"));
		IWebElement DropElement => Driver.FindElement(By.CssSelector("#droppable"));

		CustomMethods customMethods = new CustomMethods();

		public void Dropping()
		{
			Actions actions = new Actions(Driver);
			actions.DragAndDrop(DragElement, DropElement)
				.Build()
				.Perform();
		}
		public void PerformDropPage()
		{
			customMethods.Click(DropClk);
			Dropping();
		}

	}
}
