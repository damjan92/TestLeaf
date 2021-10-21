using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace TestLeaf.Pages
{
	class AutocompletePage : DriverHelper
	{
		IWebElement AutocompleteClk => Driver.FindElement(By.CssSelector("a[href='pages/autoComplete.html']"));
		IWebElement inputField => Driver.FindElement(By.Id("tags"));
		IWebElement suggestMenu => Driver.FindElement(By.ClassName("ui-menu-item-wrapper"));
		IWebElement uiMenu => Driver.FindElement(By.ClassName("ui-menu-item-wrapper"));


		CustomMethods customMethods = new CustomMethods();
		
		public void AutoComplete(string ch)
		{
			customMethods.Click(inputField);
			customMethods.EnterText(inputField, ch);
			Actions actions = new Actions(Driver);
			//customMethods.CustomWaitMethod(uiMenu);

			if (ch == "se" || ch == "sel")
            {
				Thread.Sleep(500);
				actions.SendKeys(Keys.Down).Click().Build().Perform();
                Console.WriteLine("Selenium is selected");
			}
			else if (ch == "so" || ch == "soa")
			{
				Thread.Sleep(500);
				actions.SendKeys(Keys.Down).Click().Build().Perform();
				Console.WriteLine("Soap is selected");
			}
			else if (ch == "ap" || ch == "app")
			{
				Thread.Sleep(500);
				actions.SendKeys(Keys.Down).Click().Build().Perform();
				Console.WriteLine("Appium is selected");
			}
			else if (ch == "pr" || ch == "pro")
			{
				Thread.Sleep(500);
				actions.SendKeys(Keys.Down).Click().Build().Perform();
				Console.WriteLine("Protactor is selected");
			}

		}

		public void PerformAutocompletePage()
		{
			customMethods.Click(AutocompleteClk);
			
			AutoComplete("sel");
			Thread.Sleep(500);
		}
	}
}
