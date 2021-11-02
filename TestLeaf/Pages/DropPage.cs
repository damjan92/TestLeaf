using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
	class DropPage : BasePage
	{
        public DropPage(IWebDriver Driver) : base(Driver)
        {
        }

        IWebElement DropClk => Driver.FindElement(By.CssSelector("a[href='pages/drop.html']"));
		IWebElement DragElement => Driver.FindElement(By.CssSelector("#draggable"));
		IWebElement DropElement => Driver.FindElement(By.CssSelector("#droppable"));


		public void Dropping()
		{
			Actions actions = new Actions(Driver);
			actions.DragAndDrop(DragElement, DropElement)
				.Build()
				.Perform();
		}
		public void PerformDropPage()
		{
			CustomMethods.Click(DropClk);
			Dropping();
		}

	}
}
