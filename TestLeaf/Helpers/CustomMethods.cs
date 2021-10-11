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

		public bool IsEnabled(IWebElement webElement)
		{
			if (webElement.Enabled)
			{
				Console.WriteLine("Field is enabled");
				return true;
			}
			else
			{
				Console.WriteLine("Field is not enabled");
				return false;
			}
		}

		public bool isLinkWords(IWebElement webElement, IWebElement target)
        {
			webElement.Click();
			if (target.Text.Contains("Locators and Selenium"))
			{
				Console.WriteLine("Home page  works and header is visiable");
				Driver.Navigate().Back();
				return true;
			}
			else
			{
				Console.WriteLine("HomePage  doesnt work and header is not visiable");
				return false;
			}
		}
		//Doesnt work
		public bool IsHomePageVisiable(IWebElement webElement, IWebElement target)
		{
			webElement.Click();
			if (target.Text.Contains("Locators and Selenium"))
			{
				Console.WriteLine("Home page is visiable");
				Driver.Navigate().Back();
				return true;
			}
			else
			{
				Console.WriteLine("HomePage is not visiable");
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
					Console.WriteLine("Element is displayed");
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
				Console.WriteLine("The text is " + webElement.Text);
			}
			else
			{
				Console.WriteLine("Field is not enabled, visiable or is empty");
			}
		}

		public void ClearText(IWebElement webElement)
		{
			webElement.Clear();
		}

	}
}
