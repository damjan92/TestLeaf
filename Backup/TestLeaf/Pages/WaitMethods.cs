using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;
using TestLeaf.Helpers;
using OpenQA.Selenium.Support.UI;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
	class WaitMethods : BasePage
	{
		//wait to disappear
		IWebElement WaitToDisappearClk => Driver.FindElement(By.CssSelector("a[href='pages/disapper.html']"));
		IWebElement DisappearingBtn => Driver.FindElement(By.CssSelector("b"));
		//wait to appear
		IWebElement WaitToAppearClk => Driver.FindElement(By.CssSelector("a[href='pages/appear.html']"));
		IWebElement AppearingBtn => Driver.FindElement(By.CssSelector("#btn"));
		//wait to change text
		IWebElement WaitToChangeClk => Driver.FindElement(By.CssSelector("a[href='pages/TextChange.html']"));
		IWebElement ChangingBtn => Driver.FindElement(By.CssSelector("#btn"));
		//wait for a alert
		IWebElement WaitToAlertClk => Driver.FindElement(By.CssSelector("a[href='pages/alertappear.html']"));
		IWebElement ClickAlert => Driver.FindElement(By.CssSelector("#alert"));


        public WaitMethods(IWebDriver Driver) : base(Driver)
        {
        }

        public void PerformWaitToDisappear()
		{
			CustomMethods.Click(WaitToDisappearClk);
			CustomMethods.CustomWaitMethodDisappear(DisappearingBtn, Driver);
			Driver.Navigate().Back();
		}

		public void PerformWaitToAppear()
		{
			CustomMethods.Click(WaitToAppearClk);
			CustomMethods.CustomWaitMethod(AppearingBtn, Driver);
			Driver.Navigate().Back();
		}

		public void PerformWaitForChange()
		{
			CustomMethods.Click(WaitToChangeClk);

			WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
			wait.Until(d =>
			{
				if (ChangingBtn.Displayed && ChangingBtn.Text.Contains("Click"))
				{
					LogUtil.Log("Element is changed");
					return ChangingBtn;
				}
				return null;
			});
			Driver.Navigate().Back();
		}

		public void PerformWaitForAlert()
        {
			CustomMethods.Click(WaitToAlertClk);
			CustomMethods.Click(ClickAlert);


			WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
			wait.Until(d =>
			{
				var alert = Driver.SwitchTo().Alert();

				if (alert != null)
                {
					LogUtil.Log("Alert is active");
					alert.Accept();
					return alert;
                }
				return null;
			});
			Driver.Navigate().Back();
        }

	}
}
