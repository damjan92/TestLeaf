using TestLeaf.Base;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace TestLeaf.Pages
{	
	public enum TypeOfTools
	{
		Selenium,
		Appium,
		Soap,
		Protactor,
		None
	}

	class AutocompletePage : BasePage
	{
		public AutocompletePage(IWebDriver Driver) : base(Driver)
		{
		}

		IWebElement AutocompleteClk => Driver.FindElement(By.CssSelector("a[href='pages/autoComplete.html']"));
		IWebElement InputField => Driver.FindElement(By.Id("tags"));
		IWebElement SuggestMenu => Driver.FindElement(By.ClassName("ui-menu-item-wrapper"));

		public TypeOfTools AutoComplete(string ch)
		{
			CustomMethods.Click(AutocompleteClk);
			CustomMethods.Click(InputField);
			CustomMethods.EnterText(InputField, ch);
			Actions actions = new Actions(Driver);

			if (ch == "se" || ch == "sel")
			{
				Thread.Sleep(500);
				actions.SendKeys(Keys.Down).Click().Build().Perform();
				LogUtil.Log("Selenium is selected");
				return TypeOfTools.Selenium;
			}
			else if (ch == "so" || ch == "soa")
			{
				Thread.Sleep(500);
				actions.SendKeys(Keys.Down).Click().Build().Perform();
				LogUtil.Log("Soap is selected");
				return TypeOfTools.Soap;
			}
			else if (ch == "ap" || ch == "app")
			{
				Thread.Sleep(500);
				actions.SendKeys(Keys.Down).Click().Build().Perform();
				LogUtil.Log("Appium is selected");
				return TypeOfTools.Appium;
			}
			else if (ch == "pr" || ch == "pro")
			{
				Thread.Sleep(500);
				actions.SendKeys(Keys.Down).Click().Build().Perform();
				LogUtil.Log("Protactor is selected");
				return TypeOfTools.Protactor;
			}
			else
			{
				LogUtil.Log("There is no option for entered char");
				return TypeOfTools.None;
			}

		}
		
	}
}
