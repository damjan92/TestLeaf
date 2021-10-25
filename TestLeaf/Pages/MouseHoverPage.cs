using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;
using TestLeaf.Helpers;
using OpenQA.Selenium.Interactions;

namespace TestLeaf.Pages
{
	class MouseHoverPage : DriverHelper
	{

		IWebElement HoverClk => Driver.FindElement(By.CssSelector("a[href='pages/mouseOver.html']"));
		IWebElement HoverLocation => Driver.FindElement(By.CssSelector(".btnMouse"));

		IWebElement HiddenMenuSelenium => Driver.FindElement(By.LinkText("Selenium"));

		CustomMethods customMethods = new CustomMethods();
		CustomLogger customLogger = new CustomLogger();


		public void Hovering()
		{
			Actions actions = new Actions(Driver);
			actions.MoveToElement(HoverLocation)
				.Build()
				.Perform();

            customMethods.Click(HiddenMenuSelenium);
            var alert = Driver.SwitchTo().Alert();
           
			if (alert.Text.Contains("Selenium"))
            {
                //Console.WriteLine("You selected selenium");
				customLogger.LogInfo("You selected selenium");
            } else
            {
				//Console.WriteLine("Fail");
				customLogger.LogWarn("You did not selected selenium");
            }
			alert.Accept();
		}

		public void PerformHover()
		{
			customMethods.Click(HoverClk);
			Hovering();
		}

	}
}
