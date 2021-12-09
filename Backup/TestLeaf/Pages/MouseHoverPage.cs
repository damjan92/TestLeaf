using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;
using TestLeaf.Helpers;
using OpenQA.Selenium.Interactions;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
	class MouseHoverPage : BasePage
	{

		IWebElement HoverClk => Driver.FindElement(By.CssSelector("a[href='pages/mouseOver.html']"));
		IWebElement HoverLocation => Driver.FindElement(By.CssSelector(".btnMouse"));

		IWebElement HiddenMenuSelenium => Driver.FindElement(By.LinkText("Selenium"));

        public MouseHoverPage(IWebDriver Driver) : base(Driver)
        {
        }

        public void Hovering()
		{
			Actions actions = new Actions(Driver);
			actions.MoveToElement(HoverLocation)
				.Build()
				.Perform();

            CustomMethods.Click(HiddenMenuSelenium);
            var alert = Driver.SwitchTo().Alert();
           
			if (alert.Text.Contains("Selenium"))
            {
				LogUtil.Log("You selected selenium");
            } else
            {
				LogUtil.Log("You did not selected selenium");
            }
			alert.Accept();
		}

		public void PerformHover()
		{
			CustomMethods.Click(HoverClk);
			Hovering();
		}

	}
}
