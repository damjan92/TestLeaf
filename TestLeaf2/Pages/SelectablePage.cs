using TestLeaf.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
    public class SelectablePage : BasePage
    {
        IWebElement SelectableClk => Driver.FindElement(By.CssSelector("a[href='pages/selectable.html']"));

        IWebElement StartLocation => Driver.FindElement(By.CssSelector("div[id='content'] li:nth-child(1)"));


        public SelectablePage(IWebDriver driver) : base(driver)
        {
			Driver = driver;
        }

        public Locations Selecting()
        {
			var locationByX = StartLocation.Location.X;
			var locationByY = StartLocation.Location.Y;
			CustomMethods.Click(SelectableClk);
			Actions actions = new Actions(Driver);
            actions.ClickAndHold(StartLocation).MoveByOffset(0, 200).Release()
                .Build()
                .Perform();
			return new Locations { LocationX = locationByX, LocationY = locationByY };
        }

	public class Locations
	{
		public int LocationX { get; set; }
		public int LocationY { get; set; }
	}

    }
}
