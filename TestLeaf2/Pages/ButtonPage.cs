using System;
using OpenQA.Selenium;
using TestLeaf.Helpers;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
	public class ButtonPage : BasePage
	{
        public ButtonPage(IWebDriver driver) : base(driver)
        {
			Driver = driver;
        }

        IWebElement buttonClick => Driver.FindElement(By.XPath("//a[@href='pages/Button.html']"));
		IWebElement homeBtn => Driver.FindElement(By.Id("home"));
		IWebElement positionBtn => Driver.FindElement(By.Id("position"));
		IWebElement headerTag => Driver.FindElement(By.TagName("h1"));
		IWebElement colorBtn => Driver.FindElement(By.Id("color"));
		IWebElement dimensionBtn => Driver.FindElement(By.Id("size"));

		

		public bool homePageButton()
		{
			CustomMethods.Click(buttonClick);
			CustomMethods.Click(homeBtn);
			if (headerTag.Displayed)
			{
				LogUtil.Log("Home page button works");
				return true;
			} 
			else
			{
				LogUtil.Log("HomePage button doesnt work");
				CustomMethods.TakeScreenshot(homeBtn);
				return false;
			}
		}

		public Position getButtonPositon()
		{
			CustomMethods.Click(buttonClick);
			CustomMethods.Click(positionBtn);
			int value_x = positionBtn.Location.X;
			int value_y = positionBtn.Location.Y;
			LogUtil.Log("Position X: " + value_x.ToString()
				+ " Position Y: " + value_x.ToString());

			return new Position{X = value_x, Y = value_y};
		}

		public string getButtonColour()
        {
			CustomMethods.Click(buttonClick);
			CustomMethods.Click(colorBtn);
			LogUtil.Log("Color is: " + colorBtn.GetCssValue("background-color"));
			string color = colorBtn.GetCssValue("background-color");
			return color;
        }

		public Dimnesion getButtonDimension()
        {
			CustomMethods.Click(buttonClick);
			CustomMethods.Click(dimensionBtn);
            int value_height = dimensionBtn.Size.Height;
            int value_width = dimensionBtn.Size.Width;
            LogUtil.Log("Height: " + value_height + " Width: " + value_width);
            return new Dimnesion { Height = value_height, Width = value_width};
		}
	}

    // Properties

	public class Position 
	{
		///return postion of x and y
		public int X { get; set; }

		public int Y { get; set; }
	}

    public class Dimnesion
    {
        public int Height { get; set; }

        public int Width { get; set; }
    }
}
