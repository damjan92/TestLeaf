using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TestLeaf.Helpers;
using System.Threading;

namespace TestLeaf.Pages
{
	class AlertsPage : DriverHelper
	{
		IWebElement AlertsClick => Driver.FindElement(By.CssSelector("a[href='pages/Alert.html']"));
		IWebElement AlertBoxClk => Driver.FindElement(By.CssSelector("button[onclick='normalAlert()']"));
		IWebElement AlertConfirm => Driver.FindElement(By.CssSelector("button[onclick='confirmAlert()']"));
		IWebElement resultAlert => Driver.FindElement(By.CssSelector("#result"));
		IWebElement PromtAlert => Driver.FindElement(By.CssSelector("button[onclick='confirmPrompt()']"));
		IWebElement resultPromt => Driver.FindElement(By.CssSelector("#result1"));
		IWebElement LineBreak => Driver.FindElement(By.CssSelector("button[onclick='lineBreaks()']"));
		IWebElement SweetAlert => Driver.FindElement(By.CssSelector("#btn"));

		CustomMethods customMethods = new CustomMethods();

        public void ClickAlertBox()
        {
            customMethods.Click(AlertBoxClk);
			var alert = Driver.SwitchTo().Alert();
			alert.Accept();
            Console.WriteLine("Alert is accpeted");

        }

		public bool ConfirmBox()
        {
			customMethods.Click(AlertConfirm);
			var alert = Driver.SwitchTo().Alert();
			alert.Accept();
			if (resultAlert.Displayed == true)
            {
                Console.WriteLine("You pressed OK");
				return true;
            } else
            {
                Console.WriteLine("You didnt press ok");
				return false;
            }
        }
		public bool PromptBox()
		{
			customMethods.Click(PromtAlert);
			var alert = Driver.SwitchTo().Alert();
			alert.SendKeys("TestLeaf");
			alert.Accept();
			if (!resultPromt.Text.Contains("not") == true)
			{
				Console.WriteLine("You are enjoying Testleaf");
				return true;
			}
			else
			{
				Console.WriteLine("You are not enjoying Testleaf");
				return false;
			}
		}

		public void getAlerTText()
        {
			customMethods.Click(LineBreak);
			var alert = Driver.SwitchTo().Alert();
            Console.WriteLine("Alert text is  \n" + alert.Text);
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
			customMethods.Click(AlertsClick);
			ClickAlertBox();
			Thread.Sleep(500);
			ConfirmBox();
			Thread.Sleep(500);
			PromptBox();
			Thread.Sleep(500);
			getAlerTText();
			//SweetAlertBtn();
			//Thread.Sleep(500);
		}
	}
}
