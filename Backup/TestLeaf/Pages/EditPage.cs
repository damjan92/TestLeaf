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

        IWebElement editLink => Driver.FindElement(By.XPath("//a[@href='pages/Edit.html']"));
		IWebElement emailField => Driver.FindElement(By.CssSelector("#email"));
		IWebElement appendField => Driver.FindElement(By.XPath("//input[@value='Append ']"));
		IWebElement defaultText => Driver.FindElement(By.CssSelector("input[value='TestLeaf']"));
		IWebElement clearText => Driver.FindElement(By.XPath("//input[@value='Clear me!!']"));
		IWebElement isEnabled => Driver.FindElement(By.XPath("//input[@disabled='true']"));


       
        public void PerformEditPage(string text, string appendTxt)
        {
            CustomMethods.Click(editLink);
            CustomMethods.EnterText(emailField, text);
			Thread.Sleep(500);
			CustomMethods.ActionsKeys(appendField, appendTxt, Driver);
            CustomMethods.GetText(defaultText);
			Thread.Sleep(500);
			CustomMethods.ClearText(clearText);
			Thread.Sleep(500);
			CustomMethods.IsEnabled(isEnabled);
        }
	}
}
