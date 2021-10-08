using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestLeaf.Helpers;

namespace TestLeaf.Pages
{
	class EditPage : DriverHelper
	{
		IWebElement editLink => Driver.FindElement(By.XPath("//a[@href='pages/Edit.html']"));
		IWebElement emailField => Driver.FindElement(By.CssSelector("#email"));
		IWebElement appendField => Driver.FindElement(By.XPath("//input[@value='Append ']"));
		IWebElement defaultText => Driver.FindElement(By.XPath("//input[@value='TestLeaf']"));
		IWebElement clearText => Driver.FindElement(By.XPath("//input[@value='Clear me!!']"));
		IWebElement isEnabled => Driver.FindElement(By.XPath("//input[@disabled='true']"));

        CustomMethods customMethods = new CustomMethods();

       
        public void PerformEditPage(string text, string appendTxt)
        {
            customMethods.Click(editLink);
            customMethods.EnterText(emailField, text);
			Thread.Sleep(1000);
			customMethods.ActionsKeys(appendField, appendTxt);
            customMethods.GetText(defaultText);
			Thread.Sleep(1000);
			customMethods.ClearText(clearText);
			Thread.Sleep(1000);
			customMethods.IsEnabled(isEnabled);
        }
	}
}
