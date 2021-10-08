using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestLeaf.Helpers;

namespace TestLeaf.Pages
{
	class ButtonPage : DriverHelper
	{
		IWebElement buttonClick => Driver.FindElement(By.XPath("//a[@href='pages/Button.html']"));
		IWebElement homeBtn => Driver.FindElement(By.Id("home"));
		IWebElement positionBtn => Driver.FindElement(By.Id("position"));
		IWebElement headerTag => Driver.FindElement(By.TagName("h1"));
		IWebElement colorBtn => Driver.FindElement(By.Id("color"));
		IWebElement dimensionBtn => Driver.FindElement(By.Id("size"));

		CustomMethods customMethods = new CustomMethods();

		public void homePageButton()
		{
			customMethods.Click(homeBtn);
			if (headerTag.Displayed)
			{
				Console.WriteLine("Home page button works");
				Driver.Navigate().Back();
			} 
			else
			{
				Console.WriteLine("HomePage button doesnt work");
			}
		}

		public void getButtonPositon()
		{
			customMethods.Click(positionBtn);
			Console.WriteLine("Position X: " + positionBtn.Location.X.ToString()
				+ " Position Y: " + positionBtn.Location.Y.ToString());
		}

		public void getButtonColour()
        {
			customMethods.Click(colorBtn);
            Console.WriteLine("Color is: " + colorBtn.GetCssValue("background-color"));
        }

		public void getButtonDimension()
        {
			customMethods.Click(dimensionBtn);
            Console.WriteLine("Height: " + dimensionBtn.Size.Height + " Width: " + dimensionBtn.Size.Width);
		}

		public void PerformButtonPage()
		{
			customMethods.Click(buttonClick);
			homePageButton();
			getButtonPositon();
			getButtonColour();
			getButtonDimension();
		}

	}
}
