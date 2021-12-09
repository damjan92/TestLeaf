using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using System.Threading;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
    class DropdownPage : BasePage
    {
		public DropdownPage(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		IWebElement dropdownIcon => Driver.FindElement(By.CssSelector("a[href='pages/Dropdown.html']"));
        IWebElement firstDropdown => Driver.FindElement(By.CssSelector("#dropdown1"));
        IWebElement secondDropdown => Driver.FindElement(By.CssSelector("select[name='dropdown2']"));
        IWebElement thirdDropdown => Driver.FindElement(By.CssSelector("#dropdown3"));
        IWebElement sumOfOption => Driver.FindElement(By.CssSelector(".dropdown"));
        IWebElement sendKeysDdm => Driver.FindElement(By.XPath("//div[5]//select[1]"));
        IWebElement dropdownOneClick => Driver.FindElement(By.XPath("//div[6]//select[1]//option[4]"));


       
		public string SelectElementByIndex()
		{
			CustomMethods.Click(dropdownIcon);
			CustomMethods.SelectElementByIndex(firstDropdown, 1);
			return CustomMethods.GetText(firstDropdown);
		}

		public string SelectElementByText()
		{
			CustomMethods.Click(dropdownIcon);
			CustomMethods.SelectElementByText(secondDropdown, "Selenium");
			return CustomMethods.GetText(secondDropdown);
		}

		public string SelectElementByValue()
		{
			CustomMethods.Click(dropdownIcon);
			CustomMethods.SelectElementByValue(thirdDropdown, "2");
			return CustomMethods.GetText(thirdDropdown);
		}

		public int AmountOfOption()
		{
			CustomMethods.Click(dropdownIcon);
			return CustomMethods.AmountOfOption(sumOfOption);
		}

		public string EnterTextInField()
		{
			CustomMethods.Click(dropdownIcon);
			CustomMethods.EnterText(sendKeysDdm, "Appium");
			return CustomMethods.GetText(sendKeysDdm);
		}

    }
}
