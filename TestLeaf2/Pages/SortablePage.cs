using TestLeaf.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestLeaf.Base;
using System.Threading;

namespace TestLeaf.Pages
{
	class SortablePage : BasePage
	{
		IWebElement SortableClk => Driver.FindElement(By.CssSelector("a[href='pages/sortable.html']"));
		IWebElement ItemOne => Driver.FindElement(By.XPath("div[id='mydiv'] li:nth-child(1)"));
		IWebElement ItemTwo => Driver.FindElement(By.CssSelector("li:nth-child(7)"));

        public SortablePage(IWebDriver driver) : base(driver)
        {
			Driver = driver;
        }

        public SortLocations SortTheFirstItem()
		{
			var loc_X = ItemOne.Location.X;
			var loc_Y = ItemOne.Location.Y;

			CustomMethods.Click(SortableClk);
			Actions actions = new Actions(Driver);

			actions.ClickAndHold(ItemOne).MoveByOffset(0, 100).Release()
				.Build()
				.Perform();
			return new SortLocations { FirstLocationByX = loc_X, FirstLocationByY = loc_Y };
		}

		public SortLocations SortTheSecondItem()
		{
			var loc_X = ItemTwo.Location.X;
			var loc_Y = ItemTwo.Location.Y;

			CustomMethods.Click(SortableClk);
			Actions actions = new Actions(Driver);

			actions.ClickAndHold(ItemTwo).MoveByOffset(0, -50).Release()
				.Build()
				.Perform();
			return new SortLocations { SecondLocationByX = loc_X, SecondLocationByY = loc_Y };
		}

	public class SortLocations
		{
			public int FirstLocationByX { get; set; }
			public int FirstLocationByY { get; set; }

			public int SecondLocationByX { get; set; }
			public int SecondLocationByY { get; set; }
		}

	}
}
