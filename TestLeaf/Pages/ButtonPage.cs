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
		CustomLogger customLogger = new CustomLogger();

		public void homePageButton()
		{
			customMethods.Click(homeBtn);
			if (headerTag.Displayed)
			{
				customLogger.LogInfo("Home page button works");
				Driver.Navigate().Back();
			} 
			else
			{
				customLogger.LogWarn("HomePage button doesnt work");
				customMethods.TakeScreenshot(homeBtn);
			}
		}

		public void getButtonPositon()
		{
			customMethods.Click(positionBtn);
			customLogger.LogInfo("Position X: " + positionBtn.Location.X.ToString()
				+ " Position Y: " + positionBtn.Location.Y.ToString());
		}

		public void getButtonColour()
        {
			customMethods.Click(colorBtn);
			customLogger.LogInfo("Color is: " + colorBtn.GetCssValue("background-color"));
        }

		public void getButtonDimension()
        {
			customMethods.Click(dimensionBtn);
			customLogger.LogInfo("Height: " + dimensionBtn.Size.Height + " Width: " + dimensionBtn.Size.Width);
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
