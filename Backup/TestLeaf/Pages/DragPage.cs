using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
	class DragPage : BasePage
	{
        public DragPage(IWebDriver Driver) : base(Driver)
        {
        }

        IWebElement DragClk => Driver.FindElement(By.CssSelector("a[href='pages/drag.html']"));
		IWebElement DragElement => Driver.FindElement(By.CssSelector("#draggable"));


		public void Draging()
        {
			Actions actions = new Actions(Driver);
			actions.DragAndDropToOffset(DragElement, 200, 50)
				.Build()
				.Perform();
        }

		public void PerformDragPage()
        {
			CustomMethods.Click(DragClk);
			Draging();

		}
	}
}
