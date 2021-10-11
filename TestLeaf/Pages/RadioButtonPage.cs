using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using TestLeaf.Helpers;

namespace TestLeaf.Pages
{
	class RadioButtonPage : DriverHelper
	{
		IWebElement radioButtonIcn => Driver.FindElement(By.CssSelector("a[href='pages/radio.html']"));
		IWebElement yesOption => Driver.FindElement(By.CssSelector("#yes"));
		IWebElement Ischecked => Driver.FindElement(By.Name("news"));

		CustomMethods customMethods = new CustomMethods();

		public void CheckRadioBtn ()
		{
			customMethods.Click(Ischecked);

		}
		public void PerformRadioButtonPage()
		{
			customMethods.Click(radioButtonIcn);
			customMethods.Click(yesOption);

		}
	}
}
