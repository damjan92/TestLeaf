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
        public DropdownPage(IWebDriver Driver) : base(Driver)
        {
        }

        IWebElement dropdownIcon => Driver.FindElement(By.CssSelector("a[href='pages/Dropdown.html']"));
        IWebElement firstDropdown => Driver.FindElement(By.CssSelector("#dropdown1"));
        IWebElement secondDropdown => Driver.FindElement(By.CssSelector("select[name='dropdown2']"));
        IWebElement thirdDropdown => Driver.FindElement(By.CssSelector("#dropdown3"));
        IWebElement sumOfOption => Driver.FindElement(By.CssSelector(".dropdown"));
        IWebElement sendKeysDdm => Driver.FindElement(By.XPath("//div[5]//select[1]"));
        IWebElement dropdownOneClick => Driver.FindElement(By.XPath("//div[6]//select[1]//option[4]"));


       
        public void PerformDropdownPage()
        {
            CustomMethods.Click(dropdownIcon);
            CustomMethods.SelectElementByIndex(firstDropdown, 1);
            CustomMethods.SelectElementByText(secondDropdown, "Selenium");
            CustomMethods.SelectElementByValue(thirdDropdown, "2");
            CustomMethods.AmountOfOption(sumOfOption);
            CustomMethods.EnterText(sendKeysDdm, "Appium");
            //customMethods.SelectElementByValue(dropdownOneClick, "3");
            Thread.Sleep(500);
        }
    }
}
