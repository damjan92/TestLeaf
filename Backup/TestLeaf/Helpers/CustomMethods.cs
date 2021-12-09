using OpenQA.Selenium;
using System;
using TestLeaf.Base;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace TestLeaf.Helpers
{
	public class CustomMethods
	{
		private static IWebDriver Driver;

		public CustomMethods(IWebDriver driver)
		{
			Driver = driver;
		}


		//Set methods
		public static void EnterText(IWebElement webElement, string text) => webElement.SendKeys(text);

		public static void Click(IWebElement webElement) => webElement.Click();

		public static void SelectElementByValue(IWebElement webElement, string value)
		{
			SelectElement selectElement = new SelectElement(webElement);
			selectElement.SelectByValue(value);

		}

		public static void SelectElementByText(IWebElement webElement, string text)
		{
			SelectElement selectElement = new SelectElement(webElement);
			selectElement.SelectByText(text);
		}

		public static void SelectElementByIndex(IWebElement webElement, int byIndex)
        {
			SelectElement selectElement = new SelectElement(webElement);
			selectElement.SelectByIndex(byIndex);
		}

		public static void AmountOfOption(IWebElement webElement)
		{
			SelectElement selectElement = new SelectElement(webElement);
			var items = selectElement.Options.Count;
            Console.WriteLine(items);
		}

		public static bool IsEnabled(IWebElement webElement)
		{
			if (webElement.Enabled)
			{
				LogUtil.Log("Field is enabled");
				return true;
			}
			else
			{
				LogUtil.Log("Field is not enabled");
				return false;
			}
		}

		public static bool IsLinkWords(IWebElement webElement, IWebElement target)
        {
			webElement.Click();
			if (target.Text.Contains("Locators and Selenium"))
			{
				LogUtil.Log("Home page  works and header is visiable");
				Driver.Navigate().Back();
				return true;
			}
			else
			{
				LogUtil.Log("HomePage  doesnt work and header is not visiable");
				return false;
			}
		}
		
		public static void CustomWaitMethod(IWebElement webElement, IWebDriver Driver)
		{
			WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
			wait.Until(d => 
			{ 
				if (webElement.Displayed)
				{
					LogUtil.Log("Element is displayed");
					return webElement;
				}
				return null;
			});
		}

		public static void CustomWaitMethodDisappear(IWebElement webElement, IWebDriver Driver)
		{
			WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
			wait.Until(d =>
			{
				if (!webElement.Displayed)
				{
					LogUtil.Log("Element is disappear");
					return webElement;
				}
				return null;
			});
		}
		public static void ActionsKeys(IWebElement webElement, string text, IWebDriver Driver)
		{
			Actions actions = new Actions(Driver);
			actions.Click(webElement)
				.SendKeys(text + Keys.Tab)
				.Build()
				.Perform();
		}

		public static void KeyboardActions(IWebElement webElement, IWebDriver Driver)
        {
			Actions actions = new Actions(Driver);
			actions.MoveToElement(webElement)
				.Click()
				.Perform();
        }

		//Get methods
		public static void GetText(IWebElement webElement)
        {
			if (webElement.Displayed)
			{
				LogUtil.Log("The text is: " + webElement.GetAttribute("value"));
			}
			else
			{
				LogUtil.Log("Field is not enabled, visiable or is empty");
			}
		}

		public static void ClearText(IWebElement webElement)
		{
			webElement.Clear();
		}

		// Create Screenshot
		public static void TakeScreenshot(IWebElement webElement)
        {
			Actions actions = new Actions(Driver);
			actions.MoveToElement(webElement)
				.Click()
				.Perform();
			((ITakesScreenshot)Driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);
        }


	}
}
