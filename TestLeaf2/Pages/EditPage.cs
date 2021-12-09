using OpenQA.Selenium;
using System.Threading;
using TestLeaf.Base;
using TestLeaf.Helpers;

namespace TestLeaf.Pages
{
	class EditPage : BasePage
	{
        public EditPage(IWebDriver driver) : base(Driver)
        {
			Driver = driver;
        }

        IWebElement EditLink => Driver.FindElement(By.XPath("//a[@href='pages/Edit.html']"));
		IWebElement EmailField => Driver.FindElement(By.CssSelector("#email"));
		IWebElement AppendField => Driver.FindElement(By.XPath("//input[@value='Append ']"));
		IWebElement DefaultText => Driver.FindElement(By.CssSelector("input[value='TestLeaf']"));
		IWebElement ClearText => Driver.FindElement(By.XPath("//input[@value='Clear me!!']"));
		IWebElement IsEnabled => Driver.FindElement(By.XPath("//input[@disabled='true']"));

		public string EnterTextInField(string text)
		{
			CustomMethods.Click(EditLink);
			CustomMethods.EnterText(EmailField, text);
			return CustomMethods.GetText(EmailField);
		}

		public string AppendTextInField(string appendTxt)
		{
			CustomMethods.Click(EditLink);
			CustomMethods.ActionsKeys(AppendField, appendTxt, Driver);
			return CustomMethods.GetText(AppendField);
		}

		public string GetDefaultText()
		{
			CustomMethods.Click(EditLink);
			return CustomMethods.GetText(DefaultText);
		}

		public bool ClearTextFromField()
		{
			CustomMethods.Click(EditLink);
			if (ClearText != null)
			{
				CustomMethods.ClearText(ClearText);
				return true;
			}
			else
			{
				return false;
			}
			
		}

		public bool IsFieldEnabled()
		{
			CustomMethods.Click(EditLink);
			if (CustomMethods.IsEnabled(IsEnabled) == true)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
       
	}
}
