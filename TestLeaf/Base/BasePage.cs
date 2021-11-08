using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestLeaf.Base
{
	public class BasePage
	{

		public static IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
			Driver = driver;
        }

	}
}
