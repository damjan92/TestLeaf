using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TestLeaf.Base;
using TestLeaf.Helpers;
using System.Threading;

namespace TestLeaf.Pages
{
	class AlertsPage : BasePage
	{
        public AlertsPage(IWebDriver driver) : base(driver)
        {
			Driver = driver;
        }

        IWebElement AlertsClick => Driver.FindElement(By.CssSelector("a[href='pages/Alert.html']"));
		IWebElement AlertBoxClk => Driver.FindElement(By.CssSelector("button[onclick='normalAlert()']"));
		IWebElement AlertConfirm => Driver.FindElement(By.CssSelector("button[onclick='confirmAlert()']"));
		IWebElement resultAlert => Driver.FindElement(By.CssSelector("#result"));
		IWebElement PromtAlert => Driver.FindElement(By.CssSelector("button[onclick='confirmPrompt()']"));
		IWebElement resultPromt => Driver.FindElement(By.CssSelector("#result1"));
		IWebElement LineBreak => Driver.FindElement(By.CssSelector("button[onclick='lineBreaks()']"));
		IWebElement SweetAlert => Driver.FindElement(By.CssSelector("#btn"));

		

		public void ClickAlertBox()
		{
			CustomMethods.Click(AlertBoxClk);
			var alert = Driver.SwitchTo().Alert();
			alert.Accept();
			LogUtil.Log("Alert is accepted");

		}

		public bool ConfirmBox()
		{
			CustomMethods.Click(AlertConfirm);
			var alert = Driver.SwitchTo().Alert();
			alert.Accept();
			if (resultAlert.Displayed == true)
			{
				LogUtil.Log("You pressed OK");
				return true;
			} else
			{
				LogUtil.Log("You did not press ok");
				CustomMethods.TakeScreenshot(AlertConfirm);
				return false;
			}
		}
		public bool PromptBox()
		{
			CustomMethods.Click(PromtAlert);
			var alert = Driver.SwitchTo().Alert();
			alert.SendKeys("TestLeaf");
			alert.Accept();
			if (!resultPromt.Text.Contains("not") == true)
			{
				LogUtil.Log("You are enjoying Testleaf");
				return true;
			}
			else
			{
				LogUtil.Log("You are not enjoying Testleaf");
				CustomMethods.TakeScreenshot(PromtAlert);
				return false;
			}
		}

		public void getAlerTText()
		{
			CustomMethods.Click(LineBreak);
			var alert = Driver.SwitchTo().Alert();
			LogUtil.Log("Alert text is  \n" + alert.Text);
			alert.Accept();
		}

		/*public void SweetAlertBtn()
		{
			customMethods.Click(SweetAlert);
			var alert = Driver.SwitchTo().Alert();
			alert.Accept();
		}*/

		public void PerformAlertPage()
		{
			CustomMethods.Click(AlertsClick);
			ClickAlertBox();
			Thread.Sleep(500);
			ConfirmBox();
			Thread.Sleep(500);
			PromptBox();
			Thread.Sleep(500);
			getAlerTText();
			//SweetAlertBtn();
		}
	}
}
