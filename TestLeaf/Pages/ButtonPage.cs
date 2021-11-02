using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestLeaf.Helpers;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
	class ButtonPage : BasePage
	{
        public ButtonPage(IWebDriver Driver) : base(Driver)
        {
        }

        IWebElement buttonClick => Driver.FindElement(By.XPath("//a[@href='pages/Button.html']"));
		IWebElement homeBtn => Driver.FindElement(By.Id("home"));
		IWebElement positionBtn => Driver.FindElement(By.Id("position"));
		IWebElement headerTag => Driver.FindElement(By.TagName("h1"));
		IWebElement colorBtn => Driver.FindElement(By.Id("color"));
		IWebElement dimensionBtn => Driver.FindElement(By.Id("size"));

		

		public void homePageButton()
		{
			CustomMethods.Click(homeBtn);
			if (headerTag.Displayed)
			{
				LogUtil.Log("Home page button works");
				Driver.Navigate().Back();
			} 
			else
			{
				LogUtil.Log("HomePage button doesnt work");
				CustomMethods.TakeScreenshot(homeBtn);
			}
		}

		public void getButtonPositon()
		{
			CustomMethods.Click(positionBtn);
			LogUtil.Log("Position X: " + positionBtn.Location.X.ToString()
				+ " Position Y: " + positionBtn.Location.Y.ToString());
		}

		public void getButtonColour()
        {
			CustomMethods.Click(colorBtn);
			LogUtil.Log("Color is: " + colorBtn.GetCssValue("background-color"));
        }

		public void getButtonDimension()
        {
			CustomMethods.Click(dimensionBtn);
			LogUtil.Log("Height: " + dimensionBtn.Size.Height + " Width: " + dimensionBtn.Size.Width);
		}

		public void PerformButtonPage()
		{
			CustomMethods.Click(buttonClick);
			homePageButton();
			getButtonPositon();
			getButtonColour();
			getButtonDimension();
		}

	}
}
