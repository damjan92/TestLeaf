using TestLeaf.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
	class DragPage : BasePage
	{
		public DragPage(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		IWebElement DragClk => Driver.FindElement(By.CssSelector("a[href='pages/drag.html']"));
		IWebElement DragElement => Driver.FindElement(By.CssSelector("#draggable"));


		public bool Draging()
        {
			CustomMethods.Click(DragClk);
			Actions actions = new Actions(Driver);
			actions.DragAndDropToOffset(DragElement, 200, 50)
				.Build()
				.Perform();
			return true;
        }
		
	}
}
