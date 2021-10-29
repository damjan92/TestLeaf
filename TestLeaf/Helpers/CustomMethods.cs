using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace TestLeaf.Helpers
{
	class CustomMethods : DriverHelper
	{
		CustomLogger customLogger = new CustomLogger();

		//Set methods
		public void EnterText(IWebElement webElement, string text) => webElement.SendKeys(text);

		public void Click(IWebElement webElement) => webElement.Click();

		public void SelectElementByValue(IWebElement webElement, string value)
		{
			SelectElement selectElement = new SelectElement(webElement);
			selectElement.SelectByValue(value);

		}

		public void SelectElementByText(IWebElement webElement, string text)
		{
			SelectElement selectElement = new SelectElement(webElement);
			selectElement.SelectByText(text);
		}

		public void SelectElementByIndex(IWebElement webElement, int byIndex)
        {
			SelectElement selectElement = new SelectElement(webElement);
			selectElement.SelectByIndex(byIndex);
		}

		public void AmountOfOption(IWebElement webElement)
		{
			SelectElement selectElement = new SelectElement(webElement);
			var items = selectElement.Options.Count;
            Console.WriteLine(items);
		}

		public bool IsEnabled(IWebElement webElement)
		{
			if (webElement.Enabled)
			{
				customLogger.LogInfo("Field is enabled");
				return true;
			}
			else
			{
				customLogger.LogInfo("Field is not enabled");
				return false;
			}
		}

		public bool isLinkWords(IWebElement webElement, IWebElement target)
        {
			webElement.Click();
			if (target.Text.Contains("Locators and Selenium"))
			{
				customLogger.LogInfo("Home page  works and header is visiable");
				Driver.Navigate().Back();
				return true;
			}
			else
			{
				customLogger.LogInfo("HomePage  doesnt work and header is not visiable");
				return false;
			}
		}
		
		public void CustomWaitMethod(IWebElement webElement)
		{
			WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
			wait.Until(d => 
			{ 
				if (webElement.Displayed)
				{
					customLogger.LogInfo("Element is displayed");
					return webElement;
				}
				return null;
			});
		}

		public void CustomWaitMethodDisappear(IWebElement webElement)
		{
			WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
			wait.Until(d =>
			{
				if (!webElement.Displayed)
				{
					customLogger.LogInfo("Element is disappear");
					return webElement;
				}
				return null;
			});
		}
		public void ActionsKeys(IWebElement webElement, string text)
		{
			Actions actions = new Actions(Driver);
			actions.Click(webElement)
				.SendKeys(text + Keys.Tab)
				.Build()
				.Perform();
		}

		public void KeyboardActions(IWebElement webElement)
        {
			Actions actions = new Actions(Driver);
			actions.MoveToElement(webElement)
				.Click()
				.Perform();
        }

		//Get methods
		public void GetText(IWebElement webElement)
        {
			if (webElement.Displayed)
			{
				customLogger.LogInfo("The text is: " + webElement.GetAttribute("value"));
			}
			else
			{
				customLogger.LogInfo("Field is not enabled, visiable or is empty");
			}
		}

		public void ClearText(IWebElement webElement)
		{
			webElement.Clear();
		}

		// Create Screenshot
		public void TakeScreenshot(IWebElement webElement)
        {
			Actions actions = new Actions(Driver);
			actions.MoveToElement(webElement)
				.Click()
				.Perform();
			((ITakesScreenshot)Driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);
        }


	}
}
